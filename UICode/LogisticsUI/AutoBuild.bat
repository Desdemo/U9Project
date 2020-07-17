
echo reset IIS
echo iisreset

echo beging copy UI dll to portal

copy .\bin\Debug\UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI.WebPart.dll  C:\yonyou\U9V60\Portal\UILib
copy .\bin\Debug\UFIDA.U9.Cust.BLT.ShipPlan.LogisticsUI.WebPart.pdb  C:\yonyou\U9V60\Portal\UILib

echo begin run build UI Script
echo 目录：.\..\..\bulk\\u_ui\UIScript\

echo .\..\..\..\..\..\Yonyou\UBFV60\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "User Id=sa;Password=123456;Data Source=DESKTOP-LQO9U6R;Initial Catalog=zydev;packet size=4096;Max Pool size=1500;persist security info=True" -NotDropDB -NotWriteLog -ExecuteDelete .\..\..\..\..\Code\U9demo\Logistics\bulk\\u_ui\UIScript\

echo ui buid end
pause

