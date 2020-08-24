DROP TABLE film_table;
CREATE TABLE film_table
(
	FilmID INT IDENTITY(1,1) PRIMARY KEY NOT NULL
	,Film_Name VARCHAR(10)
	,Film_Type VARCHAR(10)
	,Date_of_Release DATE
	,Director VARCHAR(30)
	,Writer VARCHAR(10)
	,Star VARCHAR(10)
	,Film_Language VARCHAR(10)
	,Offical_Website VARCHAR(max)
	,Plot_Summart VARCHAR(max)
	--PRIMARY KEY (Film_Name)
	)


-- CTRL K + C - comments
-- CTRL K + U - removes comments

-- SP_HELP film_table; -- to showtable details


 ALTER TABLE film_table
 DROP COLUMN rating
 ALTER TABLE film_table
 ADD Plot_Summary VARCHAR(max)
 ALTER TABLE film_table
 ADD Rating DEC(2,1);

ALTER TABLE film_table
ALTER COLUMN Offical_Website VARCHAR(max);

---- Be carful with character limits
INSERT INTO film_table (Film_Name, Film_Type, Date_of_Release, Director, Writer, Star, Film_Language, Offical_Website, Plot_Summary, Rating)
VALUES('Lion Kg 2','Family','1994','Guy1','Guy2','Guy3','ALL','www.Lionking.com','animation','9.99');

--DELETE FROM film_table;
--TRUNCATE TABLE film_table;

SELECT * FROM film_table;
