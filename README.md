# C# Projects

Benvenuto in **C# Projects**! Questo repository contiene una raccolta di progetti di esempio e script scritti in **C#**, sviluppati durante l'attività lavorativa o per apprendimento personale. I progetti spaziano da semplici esempi introduttivi ("Hello, World!") a frammenti di codice più specifici.

## 📁 Struttura del Progetto

Il repository è organizzato con diversi file e directory che rappresentano progetti indipendenti:

*   **`hello.cs`** e **`hello.exe`**: Il classico programma "Hello, World!" in C#. Il file `.cs` è il codice sorgente, mentre `.exe` è l'eseguibile compilato (per Windows).
*   **`esempio.cs`** e **`esempio.exe`**: Un secondo script di esempio, probabilmente per dimostrare concetti aggiuntivi come variabili, input/output o strutture di controllo.
*   **`App/`**: Directory che potrebbe contenere un'applicazione più strutturata, con più file sorgente e una logica organizzata.
*   **`info_execution_hello_cs`**: File di testo (probabilmente) con appunti, output di esecuzione o note su come compilare ed eseguire `hello.cs`.
*   **`.vscode/`**: Cartella con configurazioni specifiche per l'editor **Visual Studio Code** (es. impostazioni di build e debug).
*   **`.idea/`**: Directory con le impostazioni dell'IDE **JetBrains Rider** (o IntelliJ con plugin C#).

## 🚀 Come Compilare ed Eseguire

### Prerequisiti
*   **.NET SDK** installato (consigliata l'ultima versione stabile). Scaricabile da [dotnet.microsoft.com](https://dotnet.microsoft.com/).
*   Oppure, in alternativa, il compilatore **csc** (incluso con .NET Framework o .NET SDK).

### Compilazione con .NET CLI (Consigliata)

Per compilare ed eseguire i file sorgente `.cs`:

```bash
# Per hello.cs
dotnet build hello.cs   # Crea un eseguibile (in una sottocartella)
dotnet run --project hello.cs

# Oppure, per creare direttamente un eseguibile standalone
dotnet publish -c Release -r win-x64 --self-contained true hello.cs
```

### Compilazione Tradizionale con csc

Se hai il compilatore `csc` nel PATH (tipico con Visual Studio o .NET Framework SDK):

```bash
# Per hello.cs
csc hello.cs
# Esegui
./hello.exe
```

### Esecuzione Diretta degli Eseguibili

I file `.exe` inclusi sono già compilati per Windows. Puoi eseguirli direttamente:
*   Da riga di comando: `./hello.exe`
*   Oppure con doppio clic in Esplora Risorse.

## 📦 Dettaglio dei Progetti

### 1. Hello World (`hello.cs`)
Il programma introduttivo per eccellenza:
```csharp
using System;

class Hello
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}
```

### 2. Esempio (`esempio.cs`)
Un secondo script che probabilmente introduce:
*   Dichiarazione di variabili e tipi di dati.
*   Input da tastiera (`Console.ReadLine()`).
*   Conversioni di tipo.
*   Istruzioni condizionali (`if`, `switch`).

### 3. Applicazione (`App/`)
Questa directory potrebbe contenere un progetto più complesso, con:
*   Una struttura a classi multiple.
*   Possibile uso di interfacce o ereditarietà.
*   Un file `.csproj` per la gestione del progetto con .NET.

## 🛠️ Tecnologie Utilizzate

*   **Linguaggio**: C# (versioni recenti, compatibili con .NET 5/6/7/8).
*   **Framework**: .NET (Core) o .NET Framework, a seconda della data dei progetti.
*   **IDE**: Visual Studio Code e JetBrains Rider (come indicato dalle cartelle di configurazione).

## 📝 Note

*   I file `.exe` sono inclusi nel repository per comodità, ma in genere è buona pratica escluderli (con `.gitignore`) poiché sono file binari generati.
*   Il file `info_execution_hello_cs` può contenere informazioni utili come:
    *   Comandi esatti usati per la compilazione.
    *   Output atteso del programma.
    *   Note su potenziali errori e soluzioni.

## 🤝 Contributi

Se desideri aggiungere nuovi esempi o migliorare quelli esistenti, sentiti libero di aprire una **Issue** o una **Pull Request**. I contributi sono benvenuti!
