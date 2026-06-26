# Ped.PlayAmbientSpeech Method (String, Boolean)

﻿Ped.PlayAmbientSpeech Method (String, Boolean)

|  |  |  |
| --- | --- | --- |
| PedPlayAmbientSpeech Method (String, Boolean) | RAGE Plugin Hook Documentation |  |

[This is preliminary documentation and is subject to change.]

Plays the specified ambient speech.

**Namespace:**
 [Rage](N_Rage.htm)  
**Assembly:**
 RagePluginHook (in RagePluginHook.dll) Version: 0.0.0.0 (0.56.1131.11510)

Syntax

[C#](#)

[VB](#)

[C++](#)

[Copy](# "Copy")

```
public void PlayAmbientSpeech(
	string speechName,
	bool useMegaphoneEffect
)
```

```
Public Sub PlayAmbientSpeech ( 
	speechName As String,
	useMegaphoneEffect As Boolean
)
```

```
public:
void PlayAmbientSpeech(
	String^ speechName, 
	bool useMegaphoneEffect
)
```

#### Parameters

speechName
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The name of the ambient speech to play.

useMegaphoneEffect
:   Type: [SystemBoolean](http://msdn2.microsoft.com/en-us/library/a28wyd50)  
    Whether to use a megaphone effect.

Remarks

This overload stops any currently playing ambient speeches first.

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[PlayAmbientSpeech Overload](Overload_Rage_Ped_PlayAmbientSpeech.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.