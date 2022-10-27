/*
 Pre-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be executed before the build script.	
 Use SQLCMD syntax to include a file in the pre-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the pre-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

/* Drop the Foreign Key table first, then the one that uses the Foreign Keys. */

DROP TABLE IF EXISTS dbo.tblUserMaps
DROP TABLE IF EXISTS dbo.tblMap
DROP TABLE IF EXISTS dbo.tblCharacterArmor
DROP TABLE IF EXISTS dbo.tblArmor
DROP TABLE IF EXISTS dbo.tblArmorType
DROP TABLE IF EXISTS dbo.tblArmorStyle
DROP TABLE IF EXISTS dbo.tblCharacterCurrency
DROP TABLE IF EXISTS dbo.tblCurrency
DROP TABLE IF EXISTS dbo.tblCharacterWeapons
DROP TABLE IF EXISTS dbo.tblCharacterWeaponTypeProficiency
DROP TABLE IF EXISTS dbo.tblWeaponDamageTypes
DROP TABLE IF EXISTS dbo.tblAttackDamageTypes
DROP TABLE IF EXISTS dbo.tblSpellDamageTypes
DROP TABLE IF EXISTS dbo.tblDamageType
DROP TABLE IF EXISTS dbo.tblWeapon
DROP TABLE IF EXISTS dbo.tblCharacterSpellCharges
DROP TABLE IF EXISTS dbo.tblSpellChargesByLevel
DROP TABLE IF EXISTS dbo.tblCharacterSpells
DROP TABLE IF EXISTS dbo.tblClassSpells
DROP TABLE IF EXISTS dbo.tblSpell
DROP TABLE IF EXISTS dbo.tblCharacterAttacks
DROP TABLE IF EXISTS dbo.tblAttack
DROP TABLE IF EXISTS dbo.tblWeaponType
DROP TABLE IF EXISTS dbo.tblCharacterClasses
DROP TABLE IF EXISTS dbo.tblCharacterStats
DROP TABLE IF EXISTS dbo.tblStatModifier
DROP TABLE IF EXISTS dbo.tblCharacterSkillProficiency
DROP TABLE IF EXISTS dbo.tblSkill
DROP TABLE IF EXISTS dbo.tblCharacterLanguages
DROP TABLE IF EXISTS dbo.tblLanguage
DROP TABLE IF EXISTS dbo.tblCharacters
DROP TABLE IF EXISTS dbo.tblCharacter
DROP TABLE IF EXISTS dbo.Character
DROP TABLE IF EXISTS dbo.tblCharacterLevel
DROP TABLE IF EXISTS dbo.tblUser
DROP TABLE IF EXISTS dbo.tblRace
DROP TABLE IF EXISTS dbo.tblClass
DROP TABLE IF EXISTS dbo.tblStat
