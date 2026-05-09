---
type: development-process
status: active
---

# Development Process

This document defines the expected workflow for all changes to JaysModFramework, for both human contributors and coding agents.

---

## The Development Loop

Every change — feature, fix, or refactor — follows this sequence in order. Do not skip or reorder steps.

### 1. Make changes

Write the code. Keep changes focused and scoped to a single concern where possible.

### 2. Write tests

Add or update tests to cover the changes made. Tests must be runnable via `just test` with no additional setup.

- New behaviour → new tests.
- Changed behaviour → updated tests.
- Deleted behaviour → remove tests that no longer apply.

If a change is genuinely untestable (e.g. an RPH native call that requires a running game), document why in a code comment at the call site and note it in the relevant feature doc.

### 3. Run `just test`

```
just test
```

**This is a hard gate.** All tests must pass before proceeding. If tests fail, fix them before moving on — do not proceed to documentation or packaging with a failing test suite.

### 4. Update documentation

Update any documentation affected by the change. At minimum:

- If an interface, class, or behaviour changed: update the relevant feature technical design.
- If a decision was made: record it in the feature's `decisions.md` or as an ADR.
- If a new system was added: create or update the feature README.

Documentation that does not reflect the current implementation is worse than no documentation.

### 5. Run `just pack`

```
just pack
```

Builds a Release binary and copies it to `dist/`. The `dist/` folder is committed to the repository and must always reflect the current state of the source. Run `just pack` after every change that affects the compiled output, then commit `dist/` alongside the source changes.

---

## Checklist

For use when reviewing changes (by humans or agents):

- [ ] Code changes are complete.
- [ ] Tests cover the changes.
- [ ] `just test` passes with zero failures.
- [ ] Affected documentation is updated.
- [ ] `just pack` has been run and `dist/JaysModFramework.Rph.dll` is up to date.

---

## Related Documentation

- [Testing Strategy](wip-testing-strategy.md)
- [Coding Standards](../quality/coding-standards.md)
