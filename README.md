# malshinon
# 📓 Malshinon

A C# console application that manages and analyzes "reporting" (informing) relationships between users.  
All data is stored in a SQL database, and the system can detect potential informers and frequently reported users.

---

## 🧭 How It Works

When the program starts, a main menu is displayed:


### Menu Options:

#### [1] Submit a report

The user is prompted to enter:
- The **informer's** name
- The **reported person's** name
- The **report text** (must be written in **ALL CAPITAL LETTERS**)

Then the system:
- Checks if both users exist in the database
- If not, it adds them with a default `TIPE`:
  - `Informer`
  - `Reported`
  - Or `Both` if applicable
- Saves the report to the `Reports` table in SQL
- Returns to the main menu after each report

#### [2] Exit the program

- Immediately stops the program
- All submitted data remains saved in the SQL database

---

## 📊 Potential Detection Logic

The system dynamically updates user types based on behavior:

- **Potential Informer**:
  - More than **10 reports** submitted
  - Average report text length exceeds **100 characters**
  → The user’s `TIPE` is updated to: `Potential Informer`

- **Potential Reported**:
  - Reported more than **20 times**
  → The user’s `TIPE` is updated to: `Potential Reported`

---

## 🧰 Technologies Used

- C# (.NET Console App)
- SQL Server (MSSQL)
- ADO.NET or Entity Framework (for DB access)
- Object-oriented logic, string analysis, dictionary tracking

---

## 🚀 How to Run the Project

1. Open the solution in **Visual Studio**
2. Make sure the **connection string** to your SQL DB is correctly set
3. Run the program (`Start` or `Ctrl+F5`)
4. Follow the menu instructions:
   - Press `1` to submit reports
   - Press `2` to exit

---

## 🗃️ Example SQL Schema

```sql
-- Table for users
CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Type NVARCHAR(50)
);

-- Table for reports
CREATE TABLE Reports (
    Id INT PRIMARY KEY IDENTITY,
    InformerId INT,
    ReportedId INT,
    ReportText TEXT,
    ReportLength INT,
    FOREIGN KEY (InformerId) REFERENCES Users(Id),
    FOREIGN KEY (ReportedId) REFERENCES Users(Id)
);
