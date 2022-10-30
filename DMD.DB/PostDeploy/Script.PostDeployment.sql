/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

/* Create the tables that do not have foreign keys first. */

--:r .\DefaultData\Users.sql
--:r .\DefaultData\Stats.sql
--:r .\DefaultData\Classes.sql
--:r .\DefaultData\Races.sql
--:r .\DefaultData\CharacterLevels.sql
--:r .\DefaultData\Characters.sql
--:r .\DefaultData\Languages.sql
--:r .\DefaultData\CharacterLanguages.sql
--:r .\DefaultData\Skills.sql
--:r .\DefaultData\CharacterSkillProficiencies.sql
--:r .\DefaultData\StatModifiers.sql
--:r .\DefaultData\CharacterStats.sql
--:r .\DefaultData\CharacterClasses.sql
--:r .\DefaultData\WeaponTypes.sql
--:r .\DefaultData\Attacks.sql
--:r .\DefaultData\CharacterAttacks.sql
--:r .\DefaultData\Spells.sql
--:r .\DefaultData\ClassSpells.sql
--:r .\DefaultData\CharacterClassSpells.sql
--:r .\DefaultData\SpellChargesByLevels.sql
--:r .\DefaultData\CharacterSpellCharges.sql
--:r .\DefaultData\Weapons.sql
--:r .\DefaultData\DamageTypes.sql
--:r .\DefaultData\SpellDamageTypes.sql
--:r .\DefaultData\AttackDamageTypes.sql
--:r .\DefaultData\WeaponDamageTypes.sql
--:r .\DefaultData\CharacterWeaponTypeProficiencies.sql
--:r .\DefaultData\CharacterWeapons.sql
--:r .\DefaultData\Currencies.sql
--:r .\DefaultData\CharacterCurrencies.sql
--:r .\DefaultData\ArmorStyles.sql
--:r .\DefaultData\ArmorTypes.sql
--:r .\DefaultData\Armors.sql
--:r .\DefaultData\CharacterArmors.sql
--:r .\DefaultData\Maps.sql
--:r .\DefaultData\UserMaps.sql