del "C:\working\Orbium_5_10_1\Orbium_5_10_1\Orbium_5_10_1\Report Test\xml\*.xml" 
del "C:\working\Orbium_5_10_1\Orbium_5_10_1\Orbium_5_10_1\Report Test\*.html"

C:\working\Orbium_5_10_1\Orbium_5_10_1\packages\NUnit.ConsoleRunner.3.11.1\tools\nunit3-console.exe "C:\working\Orbium_5_10_1\Orbium_5_10_1\Orbium_5_10_1\bin\Debug\Orbium_5_10_1.dll" --result="CT01CustomerEdit.xml;format=nunit3" --work=".\xml
C:\working\Orbium_5_10_1\Orbium_5_10_1\packages\ReportUnit.1.2.1\tools\ReportUnit.exe "C:\working\Orbium_5_10_1\Orbium_5_10_1\Orbium_5_10_1\Report Test\xml" "C:\working\Orbium_5_10_1\Orbium_5_10_1\Orbium_5_10_1\Report Test"