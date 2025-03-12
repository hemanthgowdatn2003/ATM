ATM21 - ATM Management System

Overview

ATM21 is a C# Windows Forms Application that simulates an Automated Teller Machine (ATM) system. It allows users to perform various banking transactions such as deposits, withdrawals, balance inquiries, mini-statements, and PIN changes.

Features

User Authentication (Login System)

Check Account Balance

Withdraw Money

Deposit Money

Fast Cash Option

Mini Statement Generation

Change PIN

Project Structure

ATM21/
|-- ATM21.sln               # Visual Studio Solution File
|-- ATM21/                  # Main project directory
    |-- Program.cs          # Application entry point
    |-- Login.cs            # User authentication logic
    |-- Account.cs          # Account details handling
    |-- Balance.cs          # Balance checking module
    |-- Deposit.cs          # Deposit feature
    |-- Withdraw.cs         # Withdrawal feature
    |-- FastCash.cs         # Quick withdrawal option
    |-- ChangePin.cs        # Change PIN functionality
    |-- MiniStatement.cs    # Mini statement feature
    |-- HOME.cs             # Main dashboard
    |-- App.config          # Application configuration
    |-- Properties/         # Project properties
    |-- bin/                # Compiled binaries
    |-- obj/                # Temporary object files

Requirements

Windows OS

Visual Studio (2019 or later) with .NET Framework support

Installation

Clone the repository or download the source code:

git clone https://github.com/yourusername/ATM21.git

Open ATM21.sln in Visual Studio.

Build and run the project.

Usage

Launch the application.

Log in with valid credentials.

Select the desired operation (Withdraw, Deposit, Balance Inquiry, etc.).

Follow on-screen instructions to complete the transaction.

Contributing

Feel free to submit issues and pull requests to improve this project.

License

This project is open-source and available under the MIT License.

