# Projeto Domain

## Objetivo
Contém as entidades de dominimo, interfaces e regras de negócio do sistema.

## Descrição Domain
Esse projeto representa o núcleo da lógica de negócios da aplicação.
Ele deve ser independente de qualeuer infraestrutura específica ou lógica de aplicação.
Isolando o domínio, você pode reutilizar esse lógica em diferentes contextos e garantir que ela permaneça desacoplada de detalhes de implementação.




### Diferença entre Data Anotation e Fluent API

#### Data Anotation
São atributos adicionados diretamente nas propriedades da entidade.

```csharp
public class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Nome { get; set; }

    [Column("EMAIL")]
    public string Email { get; set; }
}
```
##### Vantagens:

Mais simples de escrever.
Fácil de entender.
Bom para projetos pequenos ou regras básicas.

##### Desvantagens:

Mistura regras de persistência com a entidade de domínio.
Não suporta configurações mais complexas.
Pode deixar as classes poluídas.

#### Fluent API
As configurações ficam separadas da entidade, normalmente em classes que implementam IEntityTypeConfiguration<T>.

```csharp
public class UsuarioMap : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Nome)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(x => x.Email)
               .HasColumnName("EMAIL");
    }
}
```
E no DbContext:
```csharp
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.ApplyConfigurationsFromAssembly(
        typeof(AppDbContext).Assembly);
}
```
##### Vantagens:

Mantém as entidades limpas.
Permite configurações complexas.
Facilita manutenção e organização.
É a abordagem mais utilizada em arquiteturas como DDD e Clean Architecture.

##### Desvantagens:

Exige mais código.
Pode parecer mais complexo no início.