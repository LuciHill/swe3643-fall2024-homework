# swe3643-fall2024-homework
## Luciana Hill

- HW1: created git repo and modified read me!
- HW2: created flowchart for standard dev calculator
  
'''mermaid
  flowchart TD
    start((Start Main))
    main[compute sample standard deviation]
    listEmpty{if List Empty}  
    lessThanOne{if < 1}
    sampleSD[compute standard deviation, pop = false]
    RaiseErr[Raise Error]
    computeMean[Compute Mean]
    computeVariance[Compute Variance]
    computeSqDiff[Compute Square Difference]
    
    start-->main-->sampleSD-->listEmpty
    listEmpty-->|yes|RaiseErr
    listEmpty-->|no| computeMean

    computeMean-->listEmptyMean{if List Empty}
    listEmptyMean-->|yes|RaiseErrMean[Raise Error]
    listEmptyMean-->|no|meanCalc[Calculate and return mean]

    meanCalc---computeSqDiff[Compute Square Differences]
    computeSqDiff-->listEmptySqD{if List Empty}
    listEmptySqD-->|yes|RaiseErrSqD[RaiseError]
    listEmptySqD-->|no|calcSqD[Calculate and return Square Difference]

    calcSqD--> computeVariance[Compute Variance]
    computeVariance-->ifPop{if not isPop}
    ifPop-->|yes|minus1[numVals minus 1]
    ifPop-->|no|lessThanOne
    minus1-->lessThanOne{if numVals< 1}
    lessThanOne-->|yes|RaiseErrVar[Raise Error]
    lessThanOne-->|no|calcVar[Calculate and return Variance]

    calcVar-->calcSD[Calculate and return Standard Deviation]
    calcSD-->|result|sampleSD
    calcSD-->|result|popSD

    start-->main2[Compute Population Standard Deviation]
    main2-->popSD[Compute Standard Deviation, pop=true]
'''
