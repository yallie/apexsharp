@IsTest
public class GetPutDemoTest
{
    @IsTest
    public static void GetTest()
    {
        Account acc = new Account(Name = 'Acme', Description = 'Acme Account');
        String description = (String)acc.get('Description');
        System.assertEquals('Acme Account', description);
    }

    @IsTest
    public static void PutTest()
    {
        Account acc = new Account(Name = 'test', Description = 'old desc');
        String oldDesc = (String)acc.put('description', 'new desc');
        System.assertEquals('old desc', oldDesc);
        System.assertEquals('new desc', acc.Description);
    }

}