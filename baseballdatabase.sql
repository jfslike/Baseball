--BEGIN TRANSACTION

USE Baseball;

GO

CREATE TABLE players (
	player_id INT identity(1,1) PRIMARY KEY,
	last_name VARCHAR(40) NOT NULL,
	first_name VARCHAR(40) NOT NULL,
	position VARCHAR(5) NOT NULL,
	team_name VARCHAR(40) NOT NULL,
	uniform_number INT NOT NULL
);

CREATE TABLE stadiums (
	stadium_id INT identity(1,1) PRIMARY KEY,
	name VARCHAR(40) NOT NULL,
	team_name VARCHAR(40) NOT NULL,
	city VARCHAR(40) NOT NULL,
	state VARCHAR(2) NOT NULL,
	capacity INT NOT NULL,
	year_built INT NOT NULL

);

CREATE TABLE teams (
	team_id INT identity(1,1) PRIMARY KEY,
	name VARCHAR(40) NOT NULL,
	city VARCHAR(40) NOT NULL,
	state VARCHAR(2) NOT NULL,
	founded INT NOT NULL
);

CREATE TABLE managers (
	manager_id INT identity(1,1) PRIMARY KEY,
	last_name VARCHAR(40) NOT NULL,
	first_name VARCHAR(40) NOT NULL,
	team_name VARCHAR(40) NOT NULL
	);
--PLAYERS
INSERT INTO players(last_name, first_name, position, team_name, uniform_number)
VALUES ('Martinez', 'JD', 'LF', 'Red Sox', 28)

INSERT INTO players(last_name, first_name, position, team_name, uniform_number)
VALUES ('Baez', 'Javier', '2B', 'Cubs', 9)

INSERT INTO players(last_name, first_name, position, team_name, uniform_number)
VALUES ('Suarez', 'Eugenio', '3B', 'Reds', 7)

INSERT INTO players(last_name, first_name, position, team_name, uniform_number)
VALUES ('Aguilar', 'Jesus', '1B', 'Brewers', 24)

INSERT INTO players(last_name, first_name, position, team_name, uniform_number)
VALUES ('Ramirez', 'Jose', '3B', 'Indians', 11)

INSERT INTO players(last_name, first_name, position, team_name, uniform_number)
VALUES ('Arenado', 'Nolan', '3B', 'Rockies', 28)

INSERT INTO players(last_name, first_name, position, team_name, uniform_number)
VALUES ('Story', 'Trevor', 'SS', 'Rockies', 27)

INSERT INTO players(last_name, first_name, position, team_name, uniform_number)
VALUES ('Haniger', 'Mitch', 'RF', 'Mariners', 17)

INSERT INTO players(last_name, first_name, position, team_name, uniform_number)
VALUES ('Encarnacion', 'Edwin', '1B', 'Indians', 10)

INSERT INTO players(last_name, first_name, position, team_name, uniform_number)
VALUES ('Machado', 'Manny', 'SS', 'Orioles', 13)


--STADIUMS
INSERT INTO stadiums(name, team_name, city, state, capacity, year_built)
VALUES ('Dodger Stadium', 'Dodgers', 'Los Angeles', 'CA', 56000, 1962)

INSERT INTO stadiums(name, team_name, city, state, capacity, year_built)
VALUES ('Rogers Centre', 'Blue Jays', 'Toronto', 'ON', 49282, 1989)

INSERT INTO stadiums(name, team_name, city, state, capacity, year_built)
VALUES ('Chase Field', 'Diamondbacks', 'Phoenix', 'AZ', 48686, 1998)

INSERT INTO stadiums(name, team_name, city, state, capacity, year_built)
VALUES ('Globe Life Park', 'Rangers', 'Arlington', 'TX', 48114, 1994)

INSERT INTO stadiums(name, team_name, city, state, capacity, year_built)
VALUES ('Safeco Field', 'Mariners', 'Seattle', 'WA', 47715, 1999)

INSERT INTO stadiums(name, team_name, city, state, capacity, year_built)
VALUES ('Yankee Stadium', 'Yankees', 'Bronx', 'NY', 47309, 2009)

INSERT INTO stadiums(name, team_name, city, state, capacity, year_built)
VALUES ('Oakland-Alameda County Coliseum', 'Athletics', 'Oakland', 'CA', 47170, 1966)

INSERT INTO stadiums(name, team_name, city, state, capacity, year_built)
VALUES ('Coors Field', 'Rockies', 'Denver', 'CO', 46897, 1995)

INSERT INTO stadiums(name, team_name, city, state, capacity, year_built)
VALUES ('Oriole Park at Camden Yards', 'Orioles', 'Baltimore', 'MD', 45971, 1992)

INSERT INTO stadiums(name, team_name, city, state, capacity, year_built)
VALUES ('Busch Stadium', 'Cardinals', 'St. Louis', 'MO', 45529, 2006)

--TEAMS
INSERT INTO teams(name, city, state, founded)
VALUES ('Nationals', 'Washington', 'DC', 1969)

INSERT INTO teams(name, city, state, founded)
VALUES ('Blue Jays', 'Toronto', 'ON', 1977)

INSERT INTO teams(name, city, state, founded)
VALUES ('Cardinals', 'St. Louis', 'MO', 1882)

INSERT INTO teams(name, city, state, founded)
VALUES ('Rangers', 'Arlington', 'TX', 1961)

INSERT INTO teams(name, city, state, founded)
VALUES ('Giants', 'San Francisco', 'CA', 1883)

INSERT INTO teams(name, city, state, founded)
VALUES ('Rays', 'St. Petersburg', 'FL', 1998)

INSERT INTO teams(name, city, state, founded)
VALUES ('Padres', 'San Diego', 'CA', 1969)

INSERT INTO teams(name, city, state, founded)
VALUES ('Mariners', 'Seattle', 'WA', 1977)

INSERT INTO teams(name, city, state, founded)
VALUES ('Pirates', 'Pittsburgh', 'PA', 1882)

INSERT INTO teams(name, city, state, founded)
VALUES ('Athletics', 'Oakland', 'CA', 1901)

--MANAGERS
INSERT INTO managers(last_name, first_name, team_name)
VALUES ('Showalter', 'Buck', 'Orioles')

INSERT INTO managers(last_name, first_name, team_name)
VALUES ('Lovullo', 'Torey', 'Diamondbacks')

INSERT INTO managers(last_name, first_name, team_name)
VALUES ('Cora', 'Alex', 'Red Sox')

INSERT INTO managers(last_name, first_name, team_name)
VALUES ('Snitker', 'Brian', 'Braves')

INSERT INTO managers(last_name, first_name, team_name)
VALUES ('Renteria', 'Rick', 'White Sox')

INSERT INTO managers(last_name, first_name, team_name)
VALUES ('Maddon', 'Joe', 'Cubs')

INSERT INTO managers(last_name, first_name, team_name)
VALUES ('Francona', 'Terry', 'Indians')

INSERT INTO managers(last_name, first_name, team_name)
VALUES ('Riggleman', 'Jim', 'Reds')

INSERT INTO managers(last_name, first_name, team_name)
VALUES ('Gardenhire', 'Ron', 'Tigers')

INSERT INTO managers(last_name, first_name, team_name)
VALUES ('Black', 'Bud', 'Rockies')

SELECT * FROM managers;



--ROLLBACK TRANSACTION