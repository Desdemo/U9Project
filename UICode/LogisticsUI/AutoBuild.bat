
echo reset IIS
echo iisreset

echo beging copy UI dll to portal

copy .\bin\Debug\UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI.WebPart.dll  C:\yonyou\U9V60\Portal\UILib
copy .\bin\Debug\UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI.WebPart.pdb  C:\yonyou\U9V60\Portal\UILib

echo begin run build UI Script
echo 目录：.\..\..\bulk\\u_ui\UIScript\

echo .\..\..\..\..\..\Yonyou\UBFV60\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "packet size=4096;user id=sa;Connection Timeout=150;Max Pool size=1500;data source=DESKTOP-LQO9U6R;persist security info=True;initial catalog=zydev;password=123456" -NotDropDB -NotWriteLog -ExecuteDelete .\..\..\..\..\Code\U9demo\Logistics\bulk\\u_ui\UIScript\

echo ui buid end
pause

