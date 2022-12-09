namespace Multi;

public class Multi1
{
    public void Test()
    {

#if NET7_0
            new UseMe1().Test();        
#endif
    }
}