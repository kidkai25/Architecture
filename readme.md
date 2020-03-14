# Architecture

This project is an example of architecture using new technologies and best practices.

The goal is to share knowledge and use it as reference for new projects.

Thanks for enjoying!

## Build

[![Build](https://dev.azure.com/rafaelfgx/Architecture/_apis/build/status/Build)](https://dev.azure.com/rafaelfgx/Architecture/_apis/build/status/Build)

## Code Analysis

[![Codacy](https://api.codacy.com/project/badge/Grade/3d1ea5b1f4b745488384c744cb00d51e)](https://api.codacy.com/project/badge/Grade/3d1ea5b1f4b745488384c744cb00d51e)

## Technologies

* [.NET Core 3.1](https://dotnet.microsoft.com/download)
* [ASP.NET Core 3.1](https://docs.microsoft.com/en-us/aspnet/core)
* [Entity Framework Core 3.1](https://docs.microsoft.com/en-us/ef/core)
* [C# 8.0](https://docs.microsoft.com/en-us/dotnet/csharp)
* [Angular 9](https://angular.io/docs)
* [Typescript](https://www.typescriptlang.org/docs/home.html)
* [HTML](https://www.w3schools.com/html)
* [CSS](https://www.w3schools.com/css)
* [SASS](https://sass-lang.com)
* [UIkit](https://getuikit.com/docs/introduction)
* [JWT](https://jwt.io)
* [FluentValidation](https://fluentvalidation.net)
* [Scrutor](https://github.com/khellang/Scrutor)
* [Serilog](https://serilog.net)
* [Docker](https://docs.docker.com)
* [Azure DevOps](https://dev.azure.com)

## Practices

* Clean Code
* SOLID Principles
* DDD (Domain-Driven Design)
* Code Analysis
* Separation of Concerns
* Unit of Work Pattern
* Repository Pattern
* Database Migrations
* Authentication
* Authorization
* Performance
* Logging
* DevOps

## Run

<details>
<summary>Command Line</summary>

#### Prerequisites

* [.NET Core SDK](https://aka.ms/dotnet-download)
* [SQL Server](https://go.microsoft.com/fwlink/?linkid=853016)
* [Node.js](https://nodejs.org)
* [Angular CLI](https://cli.angular.io)

#### Steps

1. Open directory **source\Web\Frontend** in command line and execute **npm run restore**.
2. Open directory **source\Web** in command line and execute **dotnet run**.
3. Open <https://localhost:8090>.

</details>

<details>
<summary>Visual Studio Code</summary>

#### Prerequisites

* [.NET Core SDK](https://aka.ms/dotnet-download)
* [SQL Server](https://go.microsoft.com/fwlink/?linkid=853016)
* [Visual Studio Code](https://code.visualstudio.com)
* [C# Extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)
* [Node.js](https://nodejs.org)
* [Angular CLI](https://cli.angular.io)

#### Steps

1. Open directory **source\Web\Frontend** in command line and execute **npm run restore**.
2. Open **source** directory in Visual Studio Code.
3. Press **F5**.

</details>

<details>
<summary>Visual Studio</summary>

#### Prerequisites

* [Visual Studio](https://visualstudio.microsoft.com)
* [Node.js](https://nodejs.org)
* [Angular CLI](https://cli.angular.io)

#### Steps

1. Open directory **source\Web\Frontend** in command line and execute **npm run restore**.
2. Open **source\Architecture.sln** in Visual Studio.
3. Set **Architecture.Web** as startup project.
4. Press **F5**.

</details>

<details>
<summary>Docker</summary>

#### Prerequisites

* [Docker](https://www.docker.com/get-started)

#### Steps

1. Execute **docker-compose up --build -d --force-recreate** in root directory.
2. Open <http://localhost:8095>.

</details>

## Utils

<details>
<summary>Books</summary>

* **Clean Code: A Handbook of Agile Software Craftsmanship** - Robert C. Martin (Uncle Bob)
* **Clean Architecture: A Craftsman's Guide to Software Structure and Design** - Robert C. Martin (Uncle Bob)
* **Implementing Domain-Driven Design** - Vaughn Vernon
* **Domain-Driven Design Distilled** - Vaughn Vernon
* **Domain-Driven Design: Tackling Complexity in the Heart of Software** - Eric Evans
* **Domain-Driven Design Reference: Definitions and Pattern Summaries** - Eric Evans

</details>

<details>
<summary>Tools</summary>

* [Visual Studio](https://visualstudio.microsoft.com)
* [Visual Studio Code](https://code.visualstudio.com)
* [SQL Server](https://www.microsoft.com/sql-server)
* [Node.js](https://nodejs.org)
* [Angular CLI](https://cli.angular.io)
* [Postman](https://www.getpostman.com)
* [Codacy](https://codacy.com)
* [StackBlitz](https://stackblitz.com)

</details>

<details>
<summary>Visual Studio Extensions</summary>

* [CodeMaid](https://marketplace.visualstudio.com/items?itemName=SteveCadwallader.CodeMaid)
* [ReSharper](https://www.jetbrains.com/resharper)

</details>

<details>
<summary>Visual Studio Code Extensions</summary>

* [Angular Language Service](https://marketplace.visualstudio.com/items?itemName=Angular.ng-template)
* [Angular Snippets](https://marketplace.visualstudio.com/items?itemName=johnpapa.Angular2)
* [Atom One Dark Theme](https://marketplace.visualstudio.com/items?itemName=akamud.vscode-theme-onedark)
* [Bracket Pair Colorizer](https://marketplace.visualstudio.com/items?itemName=CoenraadS.bracket-pair-colorizer)
* [C#](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp)
* [Debugger for Chrome](https://marketplace.visualstudio.com/items?itemName=msjsdiag.debugger-for-chrome)
* [Material Icon Theme](https://marketplace.visualstudio.com/items?itemName=PKief.material-icon-theme)
* [Sort Lines](https://marketplace.visualstudio.com/items?itemName=Tyriar.sort-lines)
* [TSLint](https://marketplace.visualstudio.com/items?itemName=ms-vscode.vscode-typescript-tslint-plugin)
* [Visual Studio Keymap](https://marketplace.visualstudio.com/items?itemName=ms-vscode.vs-keybindings)

</details>

## Nuget Packages

Packages were created to make this architecture clean of common features for any solution.

**Source:** [https://github.com/rafaelfgx/DotNetCore](https://github.com/rafaelfgx/DotNetCore)

**Published:** [https://www.nuget.org/profiles/rafaelfgx](https://www.nuget.org/profiles/rafaelfgx)

## Layers

**Web:** API (ASP.NET Core) and Frontend (Angular).

**Application:** Application flow control.

**Domain:** Business rules and domain logic.

**Model:** Classes that carries data.

**CrossCutting:** Resources used by other layers.

**Database:** Persistence of data in the database.

## Web

### Angular

#### Component

The **Component** class is responsible for being a small part of the application.

It must be as simple and small as possible.

```typescript
@Component({ selector: "app-signin", templateUrl: "./signin.component.html" })
export class AppSignInComponent {
    form = this.formBuilder.group({
        login: ["", Validators.required],
        password: ["", Validators.required]
    });

    constructor(
        private readonly formBuilder: FormBuilder,
        private readonly appAuthService: AppAuthService) {
    }

    signIn() {
        this.appAuthService.signIn(this.form.value);
    }
}
```

```html
<form [formGroup]="form">
    <fieldset>
        <div>
            <app-label for="login" text="Login"></app-label>
            <app-input-text formControlName="login" text="Login" [autofocus]="true"></app-input-text>
        </div>
        <div>
            <app-label for="password" text="Password"></app-label>
            <app-input-password formControlName="password" text="Password"></app-input-password>
        </div>
        <div>
            <app-button text="Sign in" [disabled]="form.invalid" (click)="signIn()"></app-button>
        </div>
    </fieldset>
</form>
```

#### Model

The **Model** class is responsible for containing a set of data.

```typescript
export class SignInModel {
    login!: string;
    password!: string;
}
```

#### Service

The **Service** class is responsible for accessing the API or containing logic that does not belong to component.

```typescript
@Injectable({ providedIn: "root" })
export class AppUserService {
    constructor(private readonly http: HttpClient) { }

    add(addUserModel: AddUserModel) {
        return this.http.post<number>(`Users`, addUserModel);
    }

    delete(id: number) {
        return this.http.delete(`Users/${id}`);
    }

    list() {
        return this.http.get<UserModel[]>(`Users`);
    }

    select(id: number) {
        return this.http.get<UserModel>(`Users/${id}`);
    }

    update(updateUserModel: UpdateUserModel) {
        return this.http.put(`Users/${updateUserModel.id}`, updateUserModel);
    }
}
```

#### Guard

The **Guard** class is responsible for route security.

```typescript
@Injectable({ providedIn: "root" })
export class AppRouteGuard implements CanActivate {
    constructor(
        private readonly router: Router,
        private readonly appTokenService: AppTokenService) { }

    canActivate() {
        if (this.appTokenService.any()) { return true; }
        this.router.navigate(["/login"]);
        return false;
    }
}
```

#### Error Handler

The **ErrorHandler** class is responsible for centralizing the management of all errors and exceptions.

```typescript
@Injectable({ providedIn: "root" })
export class AppErrorHandler implements ErrorHandler {
    constructor(private readonly injector: Injector) { }

    handleError(error: any) {
        if (error instanceof HttpErrorResponse) {
            switch (error.status) {
                case 401: {
                    const router = this.injector.get<Router>(Router);
                    router.navigate(["/login"]);
                    return;
                }
                case 422: {
                    const appModalService = this.injector.get<AppModalService>(AppModalService);
                    appModalService.alert(error.error);
                    return;
                }
            }
        }

        console.error(error);
    }
}
```

#### HTTP Interceptor

The **HttpInterceptor** class is responsible for intercepting request and response.

This interceptor adds JWT to header for every request.

```typescript
@Injectable({ providedIn: "root" })
export class AppHttpInterceptor implements HttpInterceptor {
    constructor(private readonly appTokenService: AppTokenService) { }

    intercept(request: HttpRequest<any>, next: HttpHandler) {
        request = request.clone({
            setHeaders: { Authorization: `Bearer ${this.appTokenService.get()}` }
        });

        return next.handle(request);
    }
}
```

#### Routes

The **Routes** constant is responsible for registering all lazy load routes.

```typescript
export const routes: Routes = [
    {
        path: "",
        component: AppParentComponent
        children: [
            { path: "view1", loadChildren: () => import("./views/view1/view1.module").then((module) => module.AppView1Module) },
            { path: "view2", loadChildren: () => import("./views/view2/view2.module").then((module) => module.AppView2Module) },
        ],
    }
];
```

### ASP.NET Core

#### Postman

Import "postman.json" file into Postman.

#### Startup

The **Startup** class is responsible for configuring the API.

```csharp
public class Startup
{
    public void Configure(IApplicationBuilder application)
    {
        application.UseCorsAllowAny();
        application.UseHttps();
        application.UseRouting();
        application.UseStaticFiles();
        application.UseResponseCompression();
        application.UseResponseCaching();
        application.UseAuthentication();
        application.UseAuthorization();
        application.UseEndpoints();
        application.UseSpa();
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddCors();
        services.AddSecurity();
        services.AddResponseCompression();
        services.AddResponseCaching();
        services.AddControllersDefault();
        services.AddSpa();
        services.AddContext();
        services.AddServices();
    }
}
```

#### Extensions

The **Extensions** class is responsible for adding and configuring services for dependency injection.

```csharp
public static class Extensions
{
    public static void AddContext(this IServiceCollection services)
    {
        var connectionString = services.GetConnectionString(nameof(Context));
        services.AddContextMigrate<Context>(options => options.UseSqlServer(connectionString));
    }

    public static void AddSecurity(this IServiceCollection services)
    {
        services.AddHash(10000, 128);
        services.AddJsonWebToken(Guid.NewGuid().ToString(), TimeSpan.FromHours(12));
        services.AddAuthenticationJwtBearer();
    }

    public static void AddServices(this IServiceCollection services)
    {
        services.AddClassesInterfaces(typeof(IUserApplicationService).Assembly);
        services.AddClassesInterfaces(typeof(IUnitOfWork).Assembly);
        services.AddFileService();
    }

    public static void AddSpa(this IServiceCollection services)
    {
        services.AddSpaStaticFiles("Frontend/dist");
    }

    public static void UseSpa(this IApplicationBuilder application)
    {
        application.UseSpaAngularServer("Frontend", "development");
    }
}
```

#### Controller

The **Controller** class is responsible for receiving, processing, and responding requests.

It must be as simple and small as possible, without any rule or logic.

```csharp
[ApiController]
[ControllerRoute]
public class UsersController : ControllerBase
{
    private readonly IUserApplicationService _userApplicationService;

    public UsersController(IUserApplicationService userApplicationService)
    {
        _userApplicationService = userApplicationService;
    }

    [HttpPost]
    public async Task<IActionResult> AddAsync(AddUserModel model)
    {
        return await _userApplicationService.AddAsync(model).ResultAsync();
    }

    [EnumAuthorize(Roles.Admin)]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(long id)
    {
        return await _userApplicationService.DeleteAsync(id).ResultAsync();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync(long id)
    {
        return await _userApplicationService.GetAsync(id).ResultAsync();
    }

    [HttpPatch("{id}/Inactivate")]
    public async Task InactivateAsync(long id)
    {
        await _userApplicationService.InactivateAsync(id);
    }

    [HttpGet("Grid")]
    public async Task<IActionResult> ListAsync([FromQuery]PagedListParameters parameters)
    {
        return await _userApplicationService.ListAsync(parameters).ResultAsync();
    }

    [HttpGet]
    public async Task<IActionResult> ListAsync()
    {
        return await _userApplicationService.ListAsync().ResultAsync();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateAsync(UpdateUserModel model)
    {
        return await _userApplicationService.UpdateAsync(model).ResultAsync();
    }
}
```

## Application

#### Application Service

The **ApplicationService** class is responsible for flow control. It uses validator, factory, domain, repository and unit of work, but it does not contain business rules or domain logic.

```csharp
public sealed class UserApplicationService : IUserApplicationService
{
    private readonly IAuthApplicationService _authApplicationService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserRepository _userRepository;

    public UserApplicationService
    (
        IAuthApplicationService authApplicationService,
        IUnitOfWork unitOfWork,
        IUserRepository userRepository
    )
    {
        _authApplicationService = authApplicationService;
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
    }

    public async Task<IResult<long>> AddAsync(AddUserModel addUserModel)
    {
        var validation = await new AddUserModelValidator().ValidateAsync(addUserModel);

        if (validation.Failed)
        {
            return Result<long>.Fail(validation.Message);
        }

        var authEntityResult = await _authApplicationService.AddAsync(addUserModel.Auth);

        if (authEntityResult.Failed)
        {
            return Result<long>.Fail(authEntityResult.Message);
        }

        var userEntity = UserFactory.Create(addUserModel, authEntityResult.Data);

        await _userRepository.AddAsync(userEntity);

        await _unitOfWork.SaveChangesAsync();

        return Result<long>.Success(userEntity.Id);
    }

    public async Task<IResult> DeleteAsync(long id)
    {
        await _userRepository.DeleteAsync(id);

        await _authApplicationService.DeleteAsync(id);

        await _unitOfWork.SaveChangesAsync();

        return Result.Success();
    }

    public Task<UserModel> GetAsync(long id)
    {
        return _userRepository.GetByIdAsync(id);
    }

    public async Task InactivateAsync(long id)
    {
        var userEntity = new UserEntity(id);

        userEntity.Inactivate();

        await _userRepository.UpdateStatusAsync(userEntity);

        await _unitOfWork.SaveChangesAsync();
    }

    public Task<PagedList<UserModel>> ListAsync(PagedListParameters parameters)
    {
        return _userRepository.Queryable.Project<UserEntity, UserModel>().ListAsync(parameters);
    }

    public async Task<IEnumerable<UserModel>> ListAsync()
    {
        return await _userRepository.Queryable.Project<UserEntity, UserModel>().ToListAsync();
    }

    public async Task<IResult> UpdateAsync(UpdateUserModel updateUserModel)
    {
        var validation = await new UpdateUserModelValidator().ValidateAsync(updateUserModel);

        if (validation.Failed)
        {
            return Result.Fail(validation.Message);
        }

        var userEntity = await _userRepository.GetAsync(updateUserModel.Id);

        if (userEntity == default)
        {
            return Result.Success();
        }

        userEntity.ChangeFullName(updateUserModel.FullName.Name, updateUserModel.FullName.Surname);

        userEntity.ChangeEmail(updateUserModel.Email);

        await _userRepository.UpdateAsync(userEntity.Id, userEntity);

        await _unitOfWork.SaveChangesAsync();

        return Result.Success();
    }
}
```

#### Factory

The **Factory** class is responsible for creating a object.

```csharp
public static class UserFactory
{
    public static UserEntity Create(AddUserModel addUserModel, AuthEntity authEntity)
    {
        return new UserEntity
        (
            new FullName(addUserModel.FullName.Name, addUserModel.FullName.Surname),
            new Email(addUserModel.Email),
            authEntity
        );
    }
}
```

## Domain

#### Entity

The **Entity** class is responsible for business rules and domain logic.

It must have an identity.

Property values must be assigned in the constructor and only be changed by methods.

```csharp
public class UserEntity : Entity<long>
{
    public UserEntity
    (
        FullName fullName,
        Email email,
        AuthEntity auth
    )
    : base(default)
    {
        FullName = fullName;
        Email = email;
        Auth = auth;
        Activate();
    }

    public UserEntity(long id) : base(id) { }

    public FullName FullName { get; private set; }

    public Email Email { get; private set; }

    public Status Status { get; private set; }

    public AuthEntity Auth { get; private set; }

    public void Activate()
    {
        Status = Status.Active;
    }

    public void Inactivate()
    {
        Status = Status.Inactive;
    }

    public void ChangeFullName(string name, string surname)
    {
        FullName = new FullName(name, surname);
    }

    public void ChangeEmail(string address)
    {
        Email = new Email(address);
    }
}
```

#### Value Object

The **ValueObject** class is responsible for grouping data that adds value to domain or an entity.

It must have no identity.

Property values must be assigned in the constructor.

```csharp
public sealed class Email : ValueObject
{
    public Email(string address)
    {
        Address = address;
    }

    public string Address { get; }

    protected override IEnumerable<object> GetEquals()
    {
        yield return Address;
    }
}
```

## Model

#### Model

The **Model** class is responsible for containing a set of data.

```csharp
public class SignInModel
{
    public string Login { get; set; }

    public string Password { get; set; }
}
```

#### Model Validator

The **ModelValidator** class is responsible for validating the model with defined rules and messages.

```csharp
public sealed class SignInModelValidator : Validator<SignInModel>
{
    public SignInModelValidator()
    {
        RuleFor(x => x.Login).NotEmpty();
        RuleFor(x => x.Password).NotEmpty();
    }
}
```

## CrossCutting

#### Enum

The **Enum** is responsible for being a set of named integer constants.

```csharp
public enum Status
{
    None = 0,
    Active = 1,
    Inactive = 2
}
```

## Database

#### Context

The **Context** class is responsible for configuring and mapping the database.

```csharp
public sealed class Context : DbContext
{
    public Context(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.AddConfigurationsFromAssembly();
        builder.Seed();
    }
}
```

#### Context Factory

The **ContextFactory** class is responsible for generating [Entity Framework Core Migrations](https://docs.microsoft.com/ef/core/managing-schemas/migrations).

```csharp
public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
{
    public Context CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<Context>();

        builder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Database;");

        return new Context(builder.Options);
    }
}
```

#### Context Seed

The **ContextSeed** class is responsible for seeding initial data.

```csharp
public static class ContextSeed
{
    public static void Seed(this ModelBuilder builder)
    {
        builder.SeedUsers();
    }

    private static void SeedUsers(this ModelBuilder builder)
    {
        builder.Entity<UserEntity>(x =>
        {
            x.HasData(new
            {
                Id = 1L,
                Status = Status.Active,
                AuthId = 1L
            });

            x.OwnsOne(y => y.FullName).HasData(new
            {
                UserEntityId = 1L,
                Name = "Administrator",
                Surname = "Administrator"
            });

            x.OwnsOne(y => y.Email).HasData(new
            {
                UserEntityId = 1L,
                Address = "administrator@administrator.com"
            });
        });
    }
}
```

#### Unit of Work

The **UnitOfWork** class is responsible for managing database transactions.

```csharp
public sealed class UnitOfWork : IUnitOfWork
{
    private readonly Context _context;

    public UnitOfWork(Context context)
    {
        _context = context;
    }

    public Task<int> SaveChangesAsync()
    {
        return _context.SaveChangesAsync();
    }
}
```

#### Configuration

The **Configuration** class is responsible for configuring and mapping an entity to a table.

```csharp
public sealed class UserConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.ToTable("Users", "User");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Property(x => x.Status).IsRequired();

        builder.OwnsOne(x => x.FullName, y =>
        {
            y.Property(x => x.Name).IsRequired().HasColumnName(nameof(FullName.Name)).HasMaxLength(100);
            y.Property(x => x.Surname).IsRequired().HasColumnName(nameof(FullName.Surname)).HasMaxLength(200);
        });

        builder.OwnsOne(x => x.Email, y =>
        {
            y.Property(x => x.Address).IsRequired().HasColumnName(nameof(UserEntity.Email)).HasMaxLength(300);
            y.HasIndex(x => x.Address).IsUnique();
        });

        builder.HasOne(x => x.Auth);
    }
}
```

#### Repository

The **Repository** class is responsible for abstracting and isolating data persistence.

```csharp
public sealed class UserRepository : Repository<UserEntity>, IUserRepository
{
    public UserRepository(Context context) : base(context) { }

    public Task<UserModel> GetByIdAsync(long id)
    {
        return Queryable.Project<UserEntity, UserModel>().FirstOrDefaultAsync(x => x.Id == id);
    }

    public Task UpdateStatusAsync(UserEntity userEntity)
    {
        return UpdatePartialAsync(userEntity.Id, new { userEntity.Status });
    }
}
```
