# Ped.PlayAmbientSpeech Method (String, String, Int32, SpeechModifier)

﻿Ped.PlayAmbientSpeech Method (String, String, Int32, SpeechModifier)

|  |  |  |
| --- | --- | --- |
| PedPlayAmbientSpeech Method (String, String, Int32, SpeechModifier) | RAGE Plugin Hook Documentation |  |

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
	string voiceName,
	string speechName,
	int number,
	SpeechModifier modifier
)
```

```
Public Sub PlayAmbientSpeech ( 
	voiceName As String,
	speechName As String,
	number As Integer,
	modifier As SpeechModifier
)
```

```
public:
void PlayAmbientSpeech(
	String^ voiceName, 
	String^ speechName, 
	int number, 
	SpeechModifier modifier
)
```

#### Parameters

voiceName
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The name of the voice to use. If null the [Ped](T_Rage_Ped.htm)'s current voice will be used.

speechName
:   Type: [SystemString](http://msdn2.microsoft.com/en-us/library/s1wwdcbf)  
    The name of the ambient speech to play.

number
:   Type: [SystemInt32](http://msdn2.microsoft.com/en-us/library/td2s409d)  
    The number of the ambient speech to play. If equal to, or less than 0, a random number will be chosen.

modifier
:   Type: [RageSpeechModifier](T_Rage_SpeechModifier.htm)  
    A value indicating how to play the speech.

Examples

Assuming the [Ped](T_Rage_Ped.htm)'s current voice is "A\_F\_M\_TRAMPBEAC\_01\_WHITE\_FULL\_01", plays a random of the following speeches.
GENERIC\_THANKS\_01
GENERIC\_THANKS\_02
GENERIC\_THANKS\_03

[Copy](# "Copy")

```
PlayAmbientSpeech(null, "GENERIC_THANKS", 0, SpeechModifier.Force);
```

Examples

Assuming the [Ped](T_Rage_Ped.htm)'s current voice is "A\_F\_M\_TRAMPBEAC\_01\_WHITE\_FULL\_01", plays GENERIC\_THANKS\_02.

[Copy](# "Copy")

```
PlayAmbientSpeech(null, "GENERIC_THANKS", 2, SpeechModifier.Force);
```

See Also

#### Reference

[Ped Class](T_Rage_Ped.htm)

[PlayAmbientSpeech Overload](Overload_Rage_Ped_PlayAmbientSpeech.htm)

[Rage Namespace](N_Rage.htm)

This version of the documentation applies to RAGE Plugin Hook v0.56.1131.11508 ALPHA

Copyright 2015-2017 © MulleDK19 / LMS ® All rights reserved.