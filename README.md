# Umvula (The Opener)

> **Hackathon Submission by Team JJTDL** > *Bridging South Africa's informal economy and formal banking ecosystems through localized operational intelligence.*

---

## 📌 Project Overview
Millions of South Africans engage in informal economic activities such running spaza shops, hawking, or operating taxi routes. They rely heavily on cash transactions due to high banking fees, complex apps, and costly data. The pressing need for innovative solutions that harness modern technology to enhance banking experiences and streamline core financial processes for the native population is what has given birth to UMVULA.

**Umvula** (meaning *"The Opener"* in Zulu) is designed to be a robust, low-overhead blended **C# Windows Forms (WinForms) Point of Sale (POS) & Operational Application** backed by **SQL Server**. Designed with .NET 9, targeting modern retail workflows, covers authentication, sales, stock management and a full dashboard UI - all developped and maintained in VS2022

### 🔗 Repository
* **GitHub:** [https://github.com/JJTDL/JJTDL.git](https://github.com/JJTDL/JJTDL.git)

---

## 🛠️ System Architecture & Modules

Umvula divides functionality into two discrete, isolated modules operating within the same foundational ecosystem: The trader side - cash fist POS and The bank staff side - operational intelligence

## ⚙️ Getting Started & Installation

### Prerequisites
* **OS:** Windows 10 / 11
* **Database:** SQL Server Express / LocalDB

### Setup Instructions
1. **Clone the Repository:**
   ```bash
   git clone [https://github.com/JJTDL/JJTDL.git](https://github.com/JJTDL/JJTDL.git)
   cd JJTDL

2. 
* Ensure NuGet packages are restored. In Visual Studio, use _Restore NuGet Packages_ or run:
   ```bash
   dotnet restore

3. **Configure your database**
* If the project uses a designer-generated settings file, update the Settings/app.config or the appropriate JSON configuration file (if present).

4. **Build**
* Use Build -> BUild Solution (Ctrl + Shift + B) or
   ```bash
   dotnet build
then run the application using _Start debugging (F5)_ 

### Project Structure
- frmLogin.cs, frmSignUp.cs, frmRecover.cs   Authentication forms.
- frmMain.cs, frmDashboard.cs   Main application UI and dashboards.
- ReceiveStock.cs, ReceiveStock.Designer.cs, ReceiveStock.resx   Receive stock form and resources.
- Salebox.cs, Salebox.Designer.cs, Salebox.resx   Cashbox / sales form and resources.
- Check Stock.cs   Inventory checking form.

