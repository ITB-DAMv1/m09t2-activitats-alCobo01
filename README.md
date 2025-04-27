# T2. Activitats - Alvaro Cobo

## Exercici 1
La llibreria _System.Diagnostics_ proporciona classes per interactuar amb processos del sistema, els registres de events i
els analitzadors de rendiment. Aquests són els mètodes, classes i propietats més importants:
1. Classe **Process**: Permet accedir a processos locals, així com iniciar i aturar processos del sistema. És útil pero executar aplicacions,
  scripts, o eines de línia de comandes des del mateix codi.
   - Mètodes
     - **Start(_string fileName_)**: Inicia un procés especificant el nom de l'arxiu
     - **Kill()**: Atura forçadament el procés associat
     - **WaitForExit()**: Espera a que el procés associat finalitzi
     - **GetProcesses()**: Obté una llista dels processos que s'estàn executant actualment
   - Propietats
     - **Id**
     - **ProcessName**
     - **HasExited**: Indica si el procés ha finalitzat
2. Classe **Stopwatch**: Ofereix una manera precisa de mesurar el temps transcorregut, sent ideal per a l'anàlisi de rendiment de fragments
   de codi.
   - Mètodes
     - **Start()**: Inicia o reprèn la mesura del temps
     - **Stop()**: Atura la mesura del temps
     - **Restart()**: Atura, reinicia i comença a mesurar de nou
     - **StartNew()**: Crea una nova instància d'_Stopwatch_, la inicia i la retorna
   - Propietats
     - **Elapsed**: Temps transcorregut com un objecte _TimeSpan_
     - **ElapsesMilliseconds**: Temps transcorregut en mil·lisegons, com _int64_
     - **IsRunning**: Obté un booleà que indica si el _Stopwatch_ actual està en marxa

## Exercici 2
## Exercici 3
## Exercici 4
La classe **Thread** (_System.Threading.Thread_) representa un fil d'execució dins d'un procés, i permet crear i controlar fils.
També pot controlar la prioritat dels fils i obtenir informació. És una forma de baix nivell per a la concurrència. Aquests són els
mètodes clau d'aquesta classe:
- **Start()**: Inicia l'execució del fil
- **Join()**: Bloqueja el fil cridat fins que el fil actual acabi
- **Sleep()**: Suspèn el fil actual durant un temps especificat

La classe **Task** (_System.Threading.Tasks_) representa una operació asíncrona, proporcionant una abstracció d’alt nivell per 
gestionar operacions asíncrones i concurrents de manera més eficient i senzilla que la classe Thread. A més, Task s’integra de 
manera nativa amb els patrons `async` i `await`, facilitant la programació asíncrona i millorant la llegibilitat del codi.

Aquí es poden veure les diferències clau entre la classe **Thread** i **Task**:

| Característica        | `Thread`                                    | `Task`                                          |
|:----------------------|:--------------------------------------------|:------------------------------------------------|
| **Nivell Abstracció** | Baix nivell (fil del SO)                    | Alt nivell (operació asíncrona)                 |
| **Recursos**          | Costós (fil dedicat per `Thread`)           | Eficient (reutilitza fils del `ThreadPool`)     |
| **Ús Principal**      | Control baix nivell, tasques llargues (rar) | Asincronia (`async/await`), I/O, paral·lelisme  |
| **Retorn de Valor**   | No directe                                  | Directe amb `Task<TResult>`                     |
| **Excepcions**        | Més complexes/risc de terminar l'app        | Gestionades, propagades amb `await`             |
| **Cancel·lació**      | Difícil (`Abort` obsolet/perillós)          | Fàcil i integrada (`CancellationToken`)         |
| **`async`/`await`**   | No compatible                               | Dissenyat per a `async`/`await`                 |
| **Recomanació**       | Casos específics de baix nivell             | **Preferit** per la majoria d'escenaris moderns |


## Exercici 5
## Exercici 6