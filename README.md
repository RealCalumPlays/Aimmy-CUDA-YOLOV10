Aimmy is a universal AI-Based Aim Alignment Mechanism developed by BabyHamsta, MarsQQ, and Taylor to make gaming more accessible for users who have difficulty aiming.

Unlike most AI-Based Aim Alignment Mechanisms, Aimmy utilizes DirectML, ONNX, and YOLOV8 to detect players, offering both higher accuracy and faster performance compared to other Aim Aligners, especially on AMD GPUs, which would not perform well on Aim Alignment Mechanisms that utilize TensorRT.

Aimmy also provides an easy to use user-interface, a wide set of features and customizability options which makes Aimmy a great option for anyone who wants to use and tailor an Aim Alignment Mechanism for a specific game without having to code.

Aimmy is 100% free to use. This means no ads, no key system, and no paywalled features. Aimmy is not, and will never be for sale for the end user, and is considered a source-available product, **not open source** as we actively discourage other developers from making commercial forks of Aimmy.

Please do not confuse Aimmy as an open-source project, we are not, and we have never been one.

Want to connect with us? Join our [Discord Server](https://discord.gg/aimmy)

If you want to share Aimmy with your friends use our [website!](https://aimmy.dev/)

# Disclaimer
This is a fork of [Aimmy](https://github.com/Babyhamsta/Aimmy/), if any problems ask us on [discord](discord.gg/aimmy).

## Setup (automatically)
- Download and run LazyAimmySetupCuda ... thats it.

### Install LazyAimmySetup

[Dropbox](https://www.dropbox.com/scl/fi/tiu0xmyztj8mip6kwbduz/LazyCudaAimmySetup.exe?rlkey=1472ye0dq3vdu7qp9att2z2as&st=01biqlu3&dl=0)

[4Shared](https://www.4shared.com/file/o2Ntd8aTku/LazyCudaAimmySetup__1_.html)

[PixelDrain](https://pixeldrain.com/u/gKenQpHB)


## Setup (manually)
- Download and Install the x64 version of [.NET Runtime 8.0.X.X](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-8.0.2-windows-x64-installer)
- Download and Install the x64 version of [.NET Runtime 7.0.X.X](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-7.0.20-windows-x64-installer)
- Download and Install the x64 version of [Visual C++ Redistributable](https://aka.ms/vs/17/release/vc_redist.x64.exe)
- Download Aimmy from [Releases](https://github.com/TaylorIsBlue/Aimmy-CUDA/releases) (Make sure it's the Aimmy zip and not Source zip)
- **Get [cuDNN 8.9.x](https://developer.nvidia.com/rdp/cudnn-archive) and [CUDA 11.8](https://developer.nvidia.com/cuda-11-8-0-download-archive)**
- Extract the Aimmy.zip file
- Run Aimmy.exe
- Choose your Model and Enjoy :)
### Troubleshooting CUDA
Sometimes, when you load a model the application closes in an exception, this could mean:
1. Your cuda installation is wrong. Check your PATH (env variables) for your Cuda installation and your cuDNN.
2. Download and Install CUDA and cuDNN of [CUDA 12.x](https://developer.nvidia.com/cuda-downloads) and [cuDNN 9.x](https://developer.nvidia.com/cudnn-downloads), maybe you need to switch versions im not sure its kind of weird.
3. Otherwise, make a ticket in our [discord server](discord.gg/aimmy)
