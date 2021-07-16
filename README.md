# raptoreum-saltyminer
An open-source miner for the Raptoreum cryptocurrency with a simple user interface.

Welcome! I created this miner interface to be used in conjunction with the [cpuminer-gr] binaries.
Please note that this application is brand new and is very likely to have several glitches and errors, which we will try to fix.

**FOR NEW USERS:**
This miner is very simple and easy for newcomers. Here's the way to use it:

1. Enter your Raptoreum (RTM) address into the designated input field. You can get a wallet from:
https://github.com/Raptor3um/raptoreum/releases/tag/1.2.15.2

2. Enter your chosen pool into the designated input field. There are quite a few different ones you can choose from.

3. Choose the proper instruction set. This is absolutely required for the application to run properly. Look below to find the proper set to choose in the field:

ZEN1:
AMD Zen & Zen+ - 1000 & 2000 series
cpuminer-zen"

ZEN2:
AMD Zen2 - 3000 & 4000 series
cpuminer-zen2

ZEN3:
AMD Zen3 - 5000 series
cpuminer-zen3

AVX512-SHA-VAES:
Ice Lake (10th gen, 10000 series Mobile)
cpuminer-avx512-sha-vaes

AVX512-SHA:
Rocket Lake (11th gen, 11000 series)
cpuminer-avx512-sha

AVX512:
Skylake-X/SP/W - HEDT 7000 & 9000 series, Xeon-W, Xeon Bronze/Silver/Gold/Platinum
Tiger Lake (11th gen, 11000 series Mobile)
cpuminer-avx512

AVX2:
Haswell (4th gen, 4000 series / 5000 HEDT) - All except i3-4000m, Pentium and Celeron
Broadwell (5th gen, 5000 series / 6000 HEDT) - All except Pentium and Celeron
Skylake (6th gen, 6000 series)
Kaby Lake (7th gen, 7000 series)
Coffee Lake (8 & 9th gen, 8000/9000 series)
Cascade Lake / Cannon Lake (10th gen, 10000 series)
cpuminer-avx2

AVX:
Sandybridge (2nd gen, 2000 series / 3000 HEDT) - All i5, i7. Some i3. Xeon v1
Ivy Bridge (3rd gen, 3000 series / 4000 HEDT) - All i5, i7, Xeon v2
cpuminer-avx

SSE42-AES:
Westmere-EP (1st gen) - Xeon 5600 series
Clarkdale & Arrandale - All except Celeron, Pentium, i3 and i5-4XXM
cpuminer-aes-sse42

SSE42:
Compiled as Nehalem SSE42

SSSE3:
Compiled as Core2 SSSE3

SSE2:
Compiled as Generic SSE2
