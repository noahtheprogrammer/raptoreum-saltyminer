# raptoreum-saltyminer
An open-source miner for the Raptoreum cryptocurrency with a simple user interface.

Welcome! I created this miner interface to be used in conjunction with the [cpuminer-gr] binaries.
Please note that this application is brand new and is very likely to have several glitches and errors, which we will try to fix.
________________________________________________________________________________________________________________________________________________________________
**For new users:**

This miner is very simple and easy for newcomers. Here's the way to use it:

1. Enter your Raptoreum (RTM) address into the designated input field. You can get a wallet from the [Wallet Application](https://github.com/Raptor3um/raptoreum/releases/tag/1.2.15.2), or from the [Discord])https://discord.gg/dJQ6cagnmX). When you join the discord, there is at least one address automatically made for you. Just DM Stacy Mom. <br> ![Stacy Mom](https://cdn.discordapp.com/attachments/836164219073331213/884022857074634782/unknown.png) <br> Send the bot `rtm.wallet` and then your wallet details appear. <br> ![Wallet Details](https://cdn.discordapp.com/attachments/836164219073331213/884023573658894346/unknown.png) <br>
There is a part called `Wallet Address 1` and `Wallet Address 2`. There's your wallet!
2. Enter your chosen pool into the designated input field. There are quite a few different ones you can choose from.
3. Enter the amount of cores you would like to run during the mining process.
4. Enter any additional information or arguements you would like to feed to the miner.
5. Choose the proper instruction set. This is absolutely required for the application to run properly.
6. Click the nice big green button and get to mining!
________________________________________________________________________________________________________________________________________________________________

**For developers or anyone who wants to modify the code:**

I wrote this UI wrapper using WinForms, along with C#. The application, when compiled, does not directly contain the binaries required to run the system.
Instead, the binaries are put into the temporary Binaries folder and then are copied into the release folder where the application is held. 
This happens when the new program is to be transfered over for a GitHub Release.
________________________________________________________________________________________________________________________________________________________________
If you would like to support us, feel free to donate below.

noahtheprogrammer:  `RWXmeVTEJYNVp2htJQ97DMYvwytWUFTi8E`

authrequest: `RXrkvhFSYk9VBp7DzueLEZaGCpWB4nuTGT`
