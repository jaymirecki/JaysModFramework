A plugin implements the IPlugin interface:                                    
- name
- activate
- deactivate
- onactivate
- ondeactivate
- ontick
- OnControlReleased
- oncontrolheld
- oncontroldoublepressed
- isactive
- description
- settings
- version
- dependencies
- interactionmenuitems

The plugin manager will dispatch ontick within the tick cycle and the control functions when controls are interacted with. A plugin doesn't need to implement all of these: any not implemented result in nothing happening. E.g. the base class implements an ontick that does nothing.

activate and deactivate probably shouldn't be implemented by individual plugins, since it should be a reliable and concise way of setting the activated status, but plugins can define side-effects of activation/deactivation in onactivate/deactivate.

Settings, by default, contains a "default activated status", for whether the plugin is active when JMF loads. A plugin can extend the settings base class to include additional settings (e.g. siren manager might want to allow configuring the control that toggles siren noise).