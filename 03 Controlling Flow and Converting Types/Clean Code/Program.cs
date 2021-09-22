//Standardization of names.

//CamelCase
//PascalCase
//Lower Case com underscore


//Names must reveal their intent.

// Bad Code
public List<int[]> getThem() {
    List<int[]> list1 = new ArrayList<int[]>();
    for (int[] x : theList)
        if (x[0] == 4)
            list1.add(x);
    return list1;
}

//Clean Code
public List<Cell> getFlaggedCells() {
    List<getFlaggedCells> flaggedCells = new ArrayList<Cell>();
    for (getFlaggedCells cell : gameBoard)
        if (cell.isFlagged())
            flaggedCells.add(cell);
    return flaggedCells;
}

//pronounceable names

// Bad Code
class DtaRcrd102
{
    private Date genymdhms;
    public Date modymdhms;
    private final String pszqint = 102;
        /* ... */
};

//Clean Code
class Custumer
{
    private Date generationTimestamp;
    private Date modificationTimestamp;
    private final String recordId = "102";
    /* ... */
};

//use searchable names

// Bad Code
for (int j = 0; j < 34; j++) {  sbyte += (testc[j] * 4) / 5;
}

//Clean Code
int realDaysPerIdealDay = 4;
const int WORK_DAYS_PER_WEEK = 5;
int sum = 0;
for (int j = 0; j <NUMBER_OF_TASKS; j++)
{
    int realTaskDays = taskEstimate[j] *
        realDaysPerIdealDay;
    int realTaskWeeks = (realDays / WORK_DAYS_PER_WEEK);
    sum += realTaskWeeks;
}

// avoid abbreviations

// Bad Code
public class Part
{
    private string m_dsc; // The textual description
    void setName(string name)
    {
        m_dsc = name;
    }
}

//Clean Code
public class Part
{
    String description;
    void setDescription(string description)
    {
        this.description = description;
    }
}

//method name
fetch, retrieve, get // as equivalente methods
// avoid using the same word for two purposes.

postPayment, deletePage, save
//methods shold have verb or verb phrase names

//Avoid mind mappings

// Bad Code
for (a = 0; a < 10; a++)
    for (b = 0; b < 10; b++)

//Clean Code
    for (i = 0; i < 10; i++)
        for (j = 0; j < 10; j++)
