EXEC_CALCULATOR = Calculator\bin\Release\net6.0-windows\Calculator.exe
EXEC_PROFILING = Profiling\bin\Release\net6.0\Profiling.exe

HELP = "Otevřete soubor Calculator.sln v této složce pomocí Visual Studia, poté se otevře řešení s projekty Calculator, Calculator.MathTests \
poté v horní liště zvolte variantu sestavení "Release" poté (vpravo) v průzkumníku řešení klikněte pravým tlačítkem na "Solution 'Calculator'..." \
a vyberte "Build solution" nyní jsou všechny spustitelné soubory sestaveny. (To samé v případě Profilingu, soubor Profiling.sln) \
Dále pro plnou funkčnost příkazu make pack je potřeba aby na stejné úrovni jako je složka "repo" byla složka "install". \
Spouštějte ve Windows PowerShell verze >= 5.0 \
Pokud chcete použít u spouštění Profilingu klasickou syntaxi '<file' musíte spouštět přes klasickou příkazovou řádku Windows (CMD). \
Spustitelný soubor pro Kalkulačku: .\Calculator\bin\Release\net6.0-windows\Calculator.exe \
Spustitelný soubor pro Profiling: .\Profiling\bin\Release\net6.0\Profiling.exe"

.PHONY: clean all pack run profile

all: run

run:
	$(EXEC_CALCULATOR)

profile:
	$(EXEC_PROFILING) < profiling_test_input.txt

pack: clean
	mkdir xmikul75_xbroza03_xcenge01_IS \
	& copy /y /q ..\hodnoceni.txt xmikul75_xbroza03_xcenge01_IS \
	& copy /y /q ..\dokumentace.pdf xmikul75_xbroza03_xcenge01_IS \
	& mkdir xmikul75_xbroza03_xcenge01_IS\src \
	& xcopy ..\src xmikul75_xbroza03_xcenge01_IS\src /E /H /C /K \
	& mkdir repo \
	& mkdir repo\mockup \
	& mkdir repo\plan \
	& mkdir repo\profiling \
	& mkdir repo\src \
	& mkdir repo\src\Calculator \
	& mkdir repo\src\Calculator.MathTests \
	& mkdir repo\.git \
	& mkdir repo\Profiling \
	& copy ..\*.* repo \
	& xcopy ..\.git repo\.git /E /H /C /K \
	& xcopy ..\mockup repo\mockup /E /H /C /K \
	& xcopy ..\plan repo\plan /E /H /C /K \
	& xcopy ..\profiling repo\profiling /E /H /C /K \
	& copy *.* repo\src \
	& xcopy Calculator repo\src\Calculator /E /H /C /K \
	& xcopy Calculator repo\src\Calculator.MathTests /E /H /C /K \
	& xcopy Profiling repo\src\Profiling\ /E /H /C /K \
	& make doc \
	& mkdir xmikul75_xbroza03_xcenge01 \
	& mkdir xmikul75_xbroza03_xcenge01\doc \
	& xcopy ..\doc xmikul75_xbroza03_xcenge01\doc /E /H /C /K \
	& mkdir xmikul75_xbroza03_xcenge01\install \
	& xcopy ..\..\install xmikul75_xbroza03_xcenge01\install /E /H /C /K \
	& move /y repo xmikul75_xbroza03_xcenge01\ 2>nul \
	& rmdir /s /q ..\doc

doc:
	doxygen Doxyfile

clean:
	rmdir /s /q ..\doc Calculator\bin Calculator\obj Calculator.MathTests\bin Calculator.MathTests\obj .vs Calculator\.vs Profiling\.vs \
	Profiling\bin Profiling\obj xmikul75_xbroza03_xcenge01_IS xmikul75_xbroza03_xcenge01 2>nul \
	& del /f Calculator\Calculator.csproj.user doxygen_warning.txt Profiling\Profiling.csproj.user *.zip 2>nul

help:
	echo $(HELP)