﻿@echo off
copy ..\\bin\debug\Kipon.Xrm.Tools.dll ..\bin\coretools
..\bin\coretools\CrmSvcUtil.exe /url:"http://kipon-dev/kip/XRMServices/2011/Organization.svc" "/username:deploy" "/password:#!dWWk56(<ahjDeQ" /domain:dom /out:Context.design.cs /ServiceContextName:ContextService /namespace:Kipon.Xrm.Tools.Entities /codewriterfilter:Kipon.Xrm.Tools.CodeWriter.CodeWriterFilter,Kipon.Xrm.Tools /codecustomization:Kipon.Xrm.Tools.CodeWriter.ToolsCustomizeCodeDomService,Kipon.Xrm.Tools
