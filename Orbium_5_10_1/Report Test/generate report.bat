del ".\xml\*.xml" 
del ".\*.html"

.\References\nunit3-console.exe "C:\working\Orbium_5_10_1\Orbium_5_10_1\Orbium_5_10_1\bin\Debug\Orbium_Desktop_5_10_1.dll" --result="CT01CustomerEdit.xml;format=nunit3" --work=".\xml
.\References\ReportUnit.exe "C:\working\Orbium_5_10_1\Orbium_5_10_1\Orbium_5_10_1\Report Test\xml" "C:\working\Orbium_5_10_1\Orbium_5_10_1\Orbium_5_10_1\Report Test"