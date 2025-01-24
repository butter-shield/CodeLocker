//print out the form
foreach (var key in form.Keys)
{
    Debug.WriteLine(key + ":" + form[key]);
}

//Need this in every controller
private readonly AppDBContext _context;

public <name>Controller(AppDBContext context)
{
    _context = context ?? throw new ArgumentNullException(nameof(context));
}