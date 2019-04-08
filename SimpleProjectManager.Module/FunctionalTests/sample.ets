;#DropDB SimpleProjectManagerEasyTest

#Application SimpleProjectManager.Win
#Application SimpleProjectManager.Web
#IfDef SimpleProjectManager.Win

*Action About...
 
*Action OK

#EndIf

#IfDef SimpleProjectManager.Web
!Action Navigation(My Details)
#EndIf
