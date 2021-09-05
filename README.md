# raptoreum-saltyminer
An open-source miner for the Raptoreum cryptocurrency with a simple user interface.

Welcome! I created this miner interface to be used in conjunction with the [cpuminer-gr] binaries.
Please note that this application is brand new and is very likely to have several glitches and errors, which we will try to fix.

**FOR NEW USERS:**

This miner is very simple and easy for newcomers. Here's the way to use it:

1. Enter your Raptoreum (RTM) address into the designated input field. You can get a wallet from:
https://github.com/Raptor3um/raptoreum/releases/tag/1.2.15.2

2. Enter your chosen pool into the designated input field. There are quite a few different ones you can choose from.

3. Choose the proper instruction set. This is absolutely required for the application to run properly.

4. Click the nice big green button and get to mining!


**FOR DEVELOPERS OR ANYONE WHO WANTS TO MESS WITH THE CODE:**

I wrote this UI wrapper using WinForms, along with C#. The application, when compiled, does not directly contain the binaries required to run the system.
Instead, the binaries are put into the temporary Binaries folder and then are copied into the release folder where the application is held. 
This happens when the new program is to be transfered over for a GitHub Release.
