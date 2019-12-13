IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Jogador] (
    [JogadorID] int NOT NULL IDENTITY,
    [Idade] int NOT NULL,
    [Nome] nvarchar(max) NULL,
    [Nacionalidade] nvarchar(max) NULL,
    CONSTRAINT [PK_Jogador] PRIMARY KEY ([JogadorID])
);

GO

CREATE TABLE [Placar] (
    [PlacarID] int NOT NULL IDENTITY,
    [JogadorID] int NOT NULL,
    [Data] datetime2 NOT NULL,
    [Pontuacao] int NOT NULL,
    CONSTRAINT [PK_Placar] PRIMARY KEY ([PlacarID]),
    CONSTRAINT [FK_Placar_Jogador_JogadorID] FOREIGN KEY ([JogadorID]) REFERENCES [Jogador] ([JogadorID]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_Placar_JogadorID] ON [Placar] ([JogadorID]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191213193252_InitialCreate', N'2.1.11-servicing-32099');

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Jogador]') AND [c].[name] = N'Nome');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Jogador] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Jogador] ALTER COLUMN [Nome] nvarchar(max) NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191213200010_SecondCreate', N'2.1.11-servicing-32099');

GO

