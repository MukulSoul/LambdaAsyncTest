# LambdaAsyncTest
 
 async has not impact on Lambda behaviour.

 Result: Failed


 dotnet store command:
 dotnet store -m LambdaAsyncTest.layer -o ./store/ --framework-version 2.1.11 -r win10-x64 --skip-optimization -v d

 dotnet publish:
 dotnet publish --manifest C:\Mukul\Git\LambdaAsyncTest\LambdaAsyncTest\store\x64\netcoreapp2.1\artifact.xml -c Release -f netcoreapp2.1 -v d -r win10-x64 -o ./deploy/

 dotnet public without manifest
  dotnet publish  -c Release -f netcoreapp2.1 -r win10-x64 -o ./deploy1/