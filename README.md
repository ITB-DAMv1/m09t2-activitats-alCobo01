# T2. Activitats - Alvaro Cobo

## Exercici 1
La llibreria _System.Diagnostics_ proporciona classes per interactuar amb processos del sistema, els registres de events i
els analitzadors de rendiment. Aquests són els mètodes, classes i propietats més importants:
- Classe **Process**
  - Permet accedir a processos locals, així com iniciar i aturar processos del sistema. És útil pero executar aplicacions,
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
- Classe **Stopwatch**
