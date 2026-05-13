---
type: requirements
feature: logger
status: active
---

# Logger — Requirements

## Overview

`Framework.Logger` is a structured logging service. It writes log messages to a file and optionally surfaces them as in-game notifications, based on configurable level thresholds read from `Framework.Settings`.

## Log Levels

Four levels in ascending order of severity:

| Level | Purpose |
|---|---|
| `Debug` | Internal framework details; high volume, low signal for normal use. |
| `Info` | Normal operational events. |
| `Warn` | Unexpected state that does not break functionality. |
| `Error` | Failures that break functionality. |

A configured level is **inclusive upward**: `LogLevel = Info` means Info, Warn, and Error are written; Debug is not.

## Functional Requirements

### API

```csharp
Logger.Debug(string message);
Logger.Info(string message);
Logger.Warn(string message);
Logger.Error(string message);
```

### File Logging

- When the message level is at or above `Settings.Logger.LogLevel`, the message is appended to the configured log file.
- Log file location: `Settings.Logger.LogLocation`. Default: `JMF/JaysModFramework.log`.
- The log file is created if it does not exist.
- Entry format: `[YYYY-MM-DD HH:MM:SS] [LEVEL] message`

### Notification Logging

- When the message level is at or above `Settings.Logger.NotificationLevel`, the message is surfaced to the player via `INativeUIService.Notify`.
- Notification format: `[LEVEL] message`. Timestamp is excluded by default.

### Initialization

- Logger is initialized after `Framework.Settings` is loaded.
- Log calls made before initialization are silently dropped.

## Out of Scope

- Log rotation or maximum file size enforcement.
- Multiple simultaneous log destinations.
- Structured or machine-readable log formats.
- Configurable notification timestamp inclusion (deferred).

## Open Questions

- Should pre-initialization log calls be queued and flushed rather than dropped? Queuing adds complexity but would capture early-startup diagnostics.

## Related Documentation

- [Settings — Requirements](../settings/requirements.md)
- [UIService — Requirements](../ui-service/requirements.md)
- [File Structure](../../architecture/file-structure.md)
