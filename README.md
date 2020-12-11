# _Bakery Point of Sale_

<div align="center">
<img src="https://github.com/jeffchiudev.png" width="200px" height="auto">
</div>
<p align="center">Authored by Jeff Chiu</p>
<p align="center">Updated on: 11.dec.2020</p>

#### A point of sale application for a Bakery, v1.0, 11.Dec.2020

## Description:

The world of pastry is a wonderful but fast paced world requiring skill and speed to produce quality products on a daily basis for a hungry customer base.  Running and operating a POS shouldn't get in the way of running a thriving bakery business.

## Site link

[Click here](https://github.com/jeffchiudev/Bakery.Solution) to visit the site.


## Setup/Installation Requirements:

### Software Requirements:

1. Internet browser of choice. Chrome is suggested.

2. A code editor like VSCode or Atom to view or edit the codebase.

3. Download C# and .NETframework [here](https://dotnet.microsoft.com/download/dotnet-core/2.2) if on windows and [here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) if on mac. To confirm install open a new Windows PowerShell window or git Bash terminal and run command `dotnet --version`. You should see a version number response similar to `2.2.203`.

### Open via Bash/GitBash:

1. Open terminal window and navigate to/create desired repository location.

2. Clone this repository onto your computer by using command: `git clone https://github.com/jeffchiudev/Bakery.Solution`

3. Navigate to cloned repository and open in Visual Studio Code with `code .`.

4. In terminal, navigate to Bakery folder and run command `dotnet build` followed by `dotnet run` to see the working program.

## Testing Specifications:

<details><summary>Click Here for Testing Specifications:</summary>
<p>

| Description | Input | Ouput |
| :---------- | :---- | :---- |
| Bread |||
| should correctly create a bread order | Bread newOrder = new Bread(5) | getType = Bread |
| should correctly calculate cost of order based on number of loaves| "1" | breadCost = 5  |
| Pastry |||
| should correctly create a pstry order |||
| should correctly count how many pastries the customer would like to order | ||
||||

</p>
</details>

## Known Bugs:

Currently optimized for desktop browsing.  Smart device integration will be added soon.

## Support and contact details:

If there are any issues, I can be contacted at jeffchiudev@gmail.com


## Technologies Used:

- C# 7.3

- .NET Core 2.2

- REPL

- VS Code

- GitHub

This extension is licensed under the MIT license.

Copyright (c) 2020 *_Jeffrey W. Chiu_*