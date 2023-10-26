namespace Seminars.StructurePatterns.Composite;
// говорят, что мужчины часто думают о римской империи

public interface IRomeEmpireWarrior
{
    void ManageWarriors(IRomeEmpireWarrior warrior);
    void War();
}