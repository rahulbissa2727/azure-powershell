---
external help file: Microsoft.Azure.PowerShell.Cmdlets.Network.dll-Help.xml
Module Name: Az.Network
online version: https://docs.microsoft.com/powershell/module/az.network/new-azfirewallpublicipaddress
schema: 2.0.0
---

# New-AzFirewallPublicIpAddress

## SYNOPSIS
This is the placeholder for the Ip Address that can be used for multi pip on azure firewall.

## SYNTAX

```
New-AzFirewallPublicIpAddress [-Address <String>] [-DefaultProfile <IAzureContextContainer>]
 [<CommonParameters>]
```

## DESCRIPTION
This is the placeholder for the Ip Address that can be used for multi pip on azure firewall.

## EXAMPLES

### Example 1
```powershell
$publicIp = New-AzFirewallPublicIpAddress -Address 20.2.3.4
```

$publicIp will be the placeholder for the ip address 20.2.3.4

## PARAMETERS

### -Address
The IP Addresses of the Firewall attached to a hub

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: Microsoft.Azure.Commands.Common.Authentication.Abstractions.Core.IAzureContextContainer
Parameter Sets: (All)
Aliases: AzContext, AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### Microsoft.Azure.Commands.Network.Models.PSAzureFirewallPublicIpAddress

## NOTES

## RELATED LINKS
