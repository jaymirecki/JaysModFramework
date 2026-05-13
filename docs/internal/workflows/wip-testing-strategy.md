---
type: testing-strategy
status: active
---

# Testing Strategy

## Core Constraint

The framework cannot be tested against a running game. There is no GTA process or RPH runtime in the test environment.

All testability is achieved through **dependency inversion**: every GTA interaction is behind an interface. Tests run against fake implementations of those interfaces.

## Project Isolation Rule

`JaysModFramework.Core` must have **zero references** to RPH or GTA dlls.

Tests reference `Core` only. The `Rph` project (which contains real GTA interactions) is never referenced by tests.

```
JaysModFramework.Core       // Framework layer: interfaces, business logic; no RPH/GTA references
JaysModFramework.Rph        // Native layer: RPH implementations; NOT referenced by tests
JaysModFramework.Tests      // references Core only
```

This rule is enforced by project structure, not convention. If `Core` references an RPH dll, it is a build-breaking error.

## The Primary Testability Seam: INativeFramework

`INativeFramework` is the top-level interface separating the Framework layer from the Native layer. Tests construct a `Framework` instance with a `FakeNativeFramework` rather than the real `RphNativeFramework`.

```csharp
// Each test creates its own Framework instance — no global state
var fake = new FakeNativeFramework();
fake.VehicleService.Configure(spawned: true);
var framework = new Framework(fake);
```

Because `Framework` is instanced (not static), each test holds its own isolated instance. Tests with different fake configurations can run in **parallel** safely.

This pattern applies equally to external plugin authors: they construct `Framework` with their own `FakeNativeFramework` in test setup, run their tests, and discard the instance.

## Fake Implementations

Each interface in `Core` has a fake implementation in the test project. Fakes are designed for assertion-friendliness:

- They record calls so tests can assert what was called and with what arguments.
- They expose internal state for inspection.
- They run synchronously (e.g. `FakeFiberService.StartNew()` runs the fiber body immediately, inline).

Examples:

| Interface | Fake | Notes |
|---|---|---|
| `INativeFramework` | `FakeNativeFramework` | Top-level entry point for test setup; composes fake services |
| `IVehicle` | `FakeVehicle` | Records position sets, color sets, etc. |
| `IFiberService` | `FakeFiberService` | Runs fibers synchronously |
| `IEntitySpawner` | `FakeEntitySpawner` | Records spawn calls; returns fake handles |

## What to Test

**Test in Core (unit tests):**
- Spawn condition evaluation logic.
- Vehicle custody state transitions.
- Entity registry register/get/despawn behavior.
- Save/load round-trip (serialize definitions → re-register → spawn).
- Outfit ownership state transitions.
- Any business rule that can be expressed against fake implementations.

**Do not test in unit tests:**
- Whether RPH natives do what we expect.
- Whether GTA spawns the correct model at a given position.
- Any behavior that requires a running game process.

## Test Runner

xUnit or NUnit. No game-specific test runner or environment setup required.

## Related Documentation

- [ADR-0003: Engine-Free Core](../architecture/decisions/adr-0003-gta6-portability.md)
- [Tech Stack](../architecture/wip-tech-stack.md)
