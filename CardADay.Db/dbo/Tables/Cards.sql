CREATE TABLE [dbo].[Cards]
    (
        [Id]            INT					NOT NULL PRIMARY KEY,
		[Guid]			UNIQUEIDENTIFIER	NOT NULL UNIQUE,
        [Name]          VARCHAR(255)		NOT NULL,
        [ManaCost]      VARCHAR(50)			NOT NULL,
        [ImageUri]      VARCHAR(MAX)		NOT NULL,
        [Type]          VARCHAR(50)			NOT NULL,
        [Rarity]        VARCHAR(20)			NOT NULL,
        [Ability]       VARCHAR(MAX)		NOT NULL,
        [FlavorText]    VARCHAR(MAX)		NOT NULL,
        [Power]         VARCHAR(4)			NOT NULL,
        [Toughness]     VARCHAR(4)			NOT NULL,
        [Artist]        VARCHAR(50)			NOT NULL,
        [SetName]       VARCHAR(50)			NOT NULL,
        [ShortSetName]  VARCHAR(10)			NOT NULL
    );