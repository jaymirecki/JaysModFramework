# InvalidHandleableException Class

﻿InvalidHandleableException Class

|  |  |  |
| --- | --- | --- |
| InvalidHandleableException Class | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

The exception that is thrown when an invalid handleable (Ped, Vehicle, Object, etc.) is passed to a method that expects a valid handleable.

Inheritance Hierarchy

[SystemObject](http://msdn2.microsoft.com/en-us/library/e5kfa45b)  
  [SystemException](http://msdn2.microsoft.com/en-us/library/c18k6c59)  
    Rage.ExceptionsInvalidHandleableException  
**Namespace:**
 [Rage.Exceptions](N_Rage_Exceptions.htm)  
**Assembly:**
 RagePluginHook (in RagePluginHook.dll) Version: 0.0.0.0 (0.56.1131.11510)

Syntax

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
[SerializableAttribute]
public sealed class InvalidHandleableException : Exception
```

```
<SerializableAttribute>
Public NotInheritable Class InvalidHandleableException
	Inherits Exception
```

```
[SerializableAttribute]
public ref class InvalidHandleableException sealed : public Exception
```

Constructors

|  | Name | Description |
| --- | --- | --- |
| Public method | [InvalidHandleableException](M_Rage_Exceptions_InvalidHandleableException__ctor.htm) | Initializes a new instance of the InvalidHandleableException class |
| Public method | [InvalidHandleableException(String)](M_Rage_Exceptions_InvalidHandleableException__ctor_2.htm) | Initializes a new instance of the InvalidHandleableException class |
| Public method | [InvalidHandleableException(IHandleable)](M_Rage_Exceptions_InvalidHandleableException__ctor_1.htm) | Initializes a new instance of the InvalidHandleableException class |
| Public method | [InvalidHandleableException(String, Exception)](M_Rage_Exceptions_InvalidHandleableException__ctor_3.htm) | Initializes a new instance of the InvalidHandleableException class |

[Top](#mainBody)

See Also

#### Reference

[Rage.Exceptions Namespace](N_Rage_Exceptions.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.