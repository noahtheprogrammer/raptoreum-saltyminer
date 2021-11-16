@echo off
@SetLocal EnableExtensions
@SetLocal EnableDelayedExpansion

if %ERRORLEVEL% EQU 0 (

  for /f "tokens=1 delims=" %%a in ('wmic cpu get Manufacturer') do for %%b in (%%a) do set MANUFACTURER=%%a
  for /f "tokens=1 delims=" %%a in ('wmic cpu get Caption') do for %%b in (%%a) do set CPUCAPTION=%%a
  for /f "tokens=1 delims=" %%a in ('wmic cpu get Description') do for %%b in (%%a) do set CPUDESCRIPTION=%%a

) else (

  for /f "tokens=1 delims=" %%a in ('PowerShell -Command "Get-WmiObject -Class Win32_Processor -ComputerName . | Select-Object -Property Manufacturer"') do for %%b in (%%a) do set MANUFACTURER=%%a
  for /f "tokens=1 delims=" %%a in ('PowerShell -Command "Get-WmiObject -Class Win32_Processor -ComputerName . | Select-Object -Property Caption"') do for %%b in (%%a) do set CPUCAPTION=%%a
  for /f "tokens=1 delims=" %%a in ('PowerShell -Command "Get-WmiObject -Class Win32_Processor -ComputerName . | Select-Object -Property Description"') do for %%b in (%%a) do set CPUDESCRIPTION=%%a

)

set /a CPU_FAMILY=0
set /a CPU_MODEL=0

set /a TYPE=0
for %%a in (!CPUCAPTION!) do (
  if !TYPE! equ 1 (
    set /a CPU_FAMILY="%%a"
    set /a TYPE=0
  )
  if !TYPE! equ 2 (
    set /a CPU_MODEL="%%a"
    set /a TYPE=0
  )
  if /I "%%a" == "Family" ( set /a TYPE=1 )
  if /I "%%a" == "Model" ( set /a TYPE=2 )
)
  
  REM CPU family == 6 - Default Intel family of consumer and server CPUs.
  REM List of used CPU Model numbers taken from: https://en.wikichip.org/wiki/intel/cpuid
  REM Big Cores (Client)
  REM Alder Lake S, P
  if !CPU_MODEL! EQU 151 (echo AVX2-SHA-VAES & :Exit)
  if !CPU_MODEL! EQU 154 (echo AVX2-SHA-VAES & :Exit)
  REM Rocket Lake S
  if !CPU_MODEL! EQU 167 (echo AVX512-SHA-VAES & :Exit)
  REM Tiger Lake H, U
  if !CPU_MODEL! EQU 141 (echo AVX512-SHA-VAES & :Exit)
  if !CPU_MODEL! EQU 140 (echo AVX512-SHA & :Exit)
  REM Ice Lake U & Y
  if !CPU_MODEL! EQU 126 (echo AVX512-SHA-VAES & :Exit)
  if !CPU_MODEL! EQU 125 (echo AVX512-SHA-VAES & :Exit)
  REM Comet Lake S, H
  if !CPU_MODEL! EQU 165 (echo AVX2 & :Exit)
  REM Comet Lake U & Amber Lake Y & Whiskey Lake U
  if !CPU_MODEL! EQU 142 (echo AVX2 & :Exit)
  REM Cannon Lake U
  if !CPU_MODEL! EQU 102 (echo AVX512-SHA & :Exit)
  REM Coffee Lake S, H, E & U
  if !CPU_MODEL! EQU 158 (echo AVX2 & :Exit)
  if !CPU_MODEL! EQU 142 (echo AVX2 & :Exit)
  REM Kaby Lake DT, H, S, X & Y, U
  if !CPU_MODEL! EQU 158 (echo AVX2 & :Exit)
  if !CPU_MODEL! EQU 142 (echo AVX2 & :Exit)
  REM Skylake (Client) DT, H, S & Y, U
  if !CPU_MODEL! EQU 94 (echo AVX2 & :Exit)
  if !CPU_MODEL! EQU 78 (echo AVX2 & :Exit)
  REM Broadwell (Client) C, W, H & U, Y, S
  if !CPU_MODEL! EQU 71 (echo AVX2 & :Exit)
  if !CPU_MODEL! EQU 61 (echo AVX2 & :Exit)
  REM Haswell (Client) GT3E & ULT & S
  if !CPU_MODEL! EQU 74 (echo AVX2 & :Exit)
  if !CPU_MODEL! EQU 71 (echo AVX2 & :Exit)
  if !CPU_MODEL! EQU 69 (echo AVX2 & :Exit)
  if !CPU_MODEL! EQU 61 (echo AVX2 & :Exit)
  if !CPU_MODEL! EQU 60 (echo AVX2 & :Exit)
  REM Ivy Bridge (Client) M, H, Gladden
  if !CPU_MODEL! EQU 58 (echo AVX & :Exit)
  REM Sandy Bridge (Client) M, H
  if !CPU_MODEL! EQU 42 (echo AVX2 & :Exit)
  REM Westmere (Client) Arrandale, Clarkdale
  if !CPU_MODEL! EQU 37 (echo AES-SSE42 & :Exit)
  REM Nehalem (Client) Auburndale, Havendale & Clarksfield
  if !CPU_MODEL! EQU 31 (echo SSE42 & :Exit)
  if !CPU_MODEL! EQU 30 (echo SSE42 & :Exit)
  
  REM Big Cores (Server)
  REM Sapphire Rapids
  if !CPU_MODEL! EQU 143 (echo AVX512-SHA-VAES & :Exit)
  REM Ice Lake (Server) DE & SP
  if !CPU_MODEL! EQU 108 (echo AVX512-SHA-VAES & :Exit)
  if !CPU_MODEL! EQU 106 (echo AVX512-SHA-VAES & :Exit)
  REM Cooper Lake & Cascade Lake SP, X, W & Skylake (Server) SP, X, DE, W
  if !CPU_MODEL! EQU 85 (echo AVX512 & :Exit)
  REM Broadwell (Server) E, EP, EX & DE, Hewitt Lake
  if !CPU_MODEL! EQU 79 (echo AVX2 & :Exit)
  if !CPU_MODEL! EQU 86 (echo AVX2 & :Exit)
  REM Haswell (Server) E, EP, EX
  if !CPU_MODEL! EQU 63 (echo AVX2 & :Exit)
  REM Ivy Bridge (Server) E, EN, EP, EX
  if !CPU_MODEL! EQU 62 (echo AVX & :Exit)
  REM Sandy Bridge (Server) E, EN, EP
  if !CPU_MODEL! EQU 45 (echo AVX & :Exit)
  REM Westmere (Server) Gulftown, EP & EX
  if !CPU_MODEL! EQU 44 (echo AES-SSE42 & :Exit)
  if !CPU_MODEL! EQU 47 (echo AES-SSE42 & :Exit)
  REM Nehalem (Server) EX & Lynnfield & Bloomfield, EP, WS
  if !CPU_MODEL! EQU 46 (echo SSE42 & :Exit)
  if !CPU_MODEL! EQU 30 (echo SSE42 & :Exit)
  if !CPU_MODEL! EQU 26 (echo SSE42 & :Exit)
  REM Penryn (Server) Dunnington & Harpertown, QC, Wolfdale, Yorkfield
  if !CPU_MODEL! EQU 29 (echo SSE2 & :Exit)
  if !CPU_MODEL! EQU 23 (echo SSE2 & :Exit)
)

  if !CPU_FAMILY! EQU 23 (
    REM Detect Zen2
    if !CPU_MODEL! EQU 144 (echo ZEN2 & :Exit)
    if !CPU_MODEL! EQU 113 (echo ZEN2 & :Exit)
    if !CPU_MODEL! EQU 104 (echo ZEN2 & :Exit)
    if !CPU_MODEL! EQU 96 (echo ZEN2 & :Exit)
    if !CPU_MODEL! EQU 71 (echo ZEN2 & :Exit)
    if !CPU_MODEL! EQU 49 (echo ZEN2 & :Exit)

    REM Detect Zen+
    if !CPU_MODEL! EQU 24 (echo ZEN & :Exit)
    if !CPU_MODEL! EQU 8 (echo ZEN & :Exit)
    
    REM Detect Zen
    if !CPU_MODEL! EQU 32 (echo ZEN & :Exit)
    if !CPU_MODEL! EQU 24 (echo ZEN & :Exit)
    if !CPU_MODEL! EQU 17 (echo ZEN & :Exit)
    if !CPU_MODEL! EQU 1 (echo ZEN & :Exit)
  )

  if !CPU_FAMILY! EQU 21 (
    REM Detect Bulldozer
    if !CPU_MODEL! EQU 1 (echo AVX & :Exit)
    
    REM Detect Piledriver
    if !CPU_MODEL! EQU 2 (echo AVX & :Exit)
    if !CPU_MODEL! EQU 17 (echo AVX & :Exit)
    if !CPU_MODEL! EQU 19 (echo AVX & :Exit)

    REM Detect Steamroller
    if !CPU_MODEL! EQU 48 (echo AVX & :Exit)
    if !CPU_MODEL! EQU 56 (echo AVX & :Exit)
    
    REM Detect Excavator
    if !CPU_MODEL! EQU 96 (echo AVX2 & :Exit)
    if !CPU_MODEL! EQU 101 (echo AVX2 & :Exit)
    if !CPU_MODEL! EQU 112 (echo AVX2 & :Exit)
  )
)

:Exit
pause
exit