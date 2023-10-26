namespace Seminars.StructurePatterns.Composite;

// трибунал является нашим композитным классом для управления
public class Tribunal : IRomeEmpireWarrior
{
    private readonly List<IRomeEmpireWarrior> _warriors = new List<IRomeEmpireWarrior>();
    
    public void ManageWarriors(IRomeEmpireWarrior warrior)
    {
        _warriors.Add(warrior);
    }

    public void War()
    {
        foreach (var romeEmpireWarrior in _warriors)
        {
            romeEmpireWarrior.War();
        }
    }
}