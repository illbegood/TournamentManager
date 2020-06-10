CREATE TABLE Players (
id INT NOT NULL IDENTITY(1,1),
name VARCHAR(255) NOT NULL,
PRIMARY KEY (id)
);

CREATE TABLE Teams (
id INT NOT NULL IDENTITY(1,1),
name VARCHAR(255) NOT NULL,
PRIMARY KEY (id)
);

CREATE TABLE Tournaments (
id INT NOT NULL IDENTITY(1,1),
name VARCHAR(255) NOT NULL,
begin_date DATE,
end_date DATE,
game_id INT NOT NULL,
PRIMARY KEY (id)
);

CREATE TABLE TournamentsTeams (
tournament_id INT NOT NULL,
team_id INT NOT NULL,
place_min INT NOT NULL,
place_max INT NOT NULL,
PRIMARY KEY (tournament_id,team_id)
);

CREATE TABLE PlayersTeams (
player_id INT NOT NULL,
team_id INT NOT NULL,
PRIMARY KEY (player_id, team_id)
);

CREATE TABLE Matches (
id INT NOT NULL IDENTITY(1,1),
team1score INT NOT NULL DEFAULT '0',
team2score INT NOT NULL DEFAULT '0',
tournament_id INT NOT NULL,
team1_id INT NOT NULL,
team2_id INT NOT NULL,
match_category_id INT NOT NULL,
match_format_id INT NOT NULL,
PRIMARY KEY (id)
);

CREATE TABLE Games (
id INT NOT NULL IDENTITY(1,1),
name VARCHAR(255) NOT NULL,
PRIMARY KEY (id)
);

CREATE TABLE MatchCategories (
id INT NOT NULL IDENTITY(1,1),
name VARCHAR(255) NOT NULL,
PRIMARY KEY (id)
);

CREATE TABLE MatchFormats (
id INT NOT NULL,
name VARCHAR(255) NOT NULL,
PRIMARY KEY (id)
);

CREATE TABLE Prizedistributions (
id INT NOT NULL IDENTITY(1,1),
place INT NOT NULL UNIQUE,
amount INT NOT NULL DEFAULT '0',
tournament_id INT NOT NULL,
PRIMARY KEY (id)
);

ALTER TABLE Tournaments ADD CONSTRAINT Tournaments_fk0 FOREIGN KEY (game_id) REFERENCES Games(id);

ALTER TABLE TournamentsTeams ADD CONSTRAINT TournamentsTeams_fk0 FOREIGN KEY (tournament_id) REFERENCES Tournaments(id);

ALTER TABLE TournamentsTeams ADD CONSTRAINT TournamentsTeams_fk1 FOREIGN KEY (team_id) REFERENCES Teams(id);

ALTER TABLE PlayersTeams ADD CONSTRAINT PlayersTeams_fk0 FOREIGN KEY (player_id) REFERENCES Players(id);

ALTER TABLE PlayersTeams ADD CONSTRAINT PlayersTeams_fk1 FOREIGN KEY (team_id) REFERENCES Teams(id);

ALTER TABLE Matches ADD CONSTRAINT Matches_fk0 FOREIGN KEY (tournament_id) REFERENCES Tournaments(id);

ALTER TABLE Matches ADD CONSTRAINT Matches_fk1 FOREIGN KEY (team1_id) REFERENCES Teams(id);

ALTER TABLE Matches ADD CONSTRAINT Matches_fk2 FOREIGN KEY (team2_id) REFERENCES Teams(id);

ALTER TABLE Matches ADD CONSTRAINT Matches_fk3 FOREIGN KEY (match_category_id) REFERENCES MatchCategories(id);

ALTER TABLE Matches ADD CONSTRAINT Matches_fk4 FOREIGN KEY (match_format_id) REFERENCES MatchFormats(id);

ALTER TABLE Prizedistributions ADD CONSTRAINT Prizedistributions_fk0 FOREIGN KEY (tournament_id) REFERENCES Tournaments(id);