# INVICTUS DASHBOARD API

## API Documentation

### Adding new scores

#### REQUEST

`GET` `/add/<PlayerName>/<Score>`

#### RESPONSE

`<UniqueId>`

example:

REQUEST `/add/Saket/944` will add 944 score with name Saket

RESPONSE `121` This is the unique Id for the newly added value to fetch the leaderboard


### Fetching leaderboard

#### REQUEST

`GET` `/<PlayerId>`

#### RESPONSE

`<UniqueId>|<PlayerName>|<PlayerScore>|<PlayerRank>
<UniqueId>|<Rank1PlayerName>|<Rank1PlayerScore>|<Rank1PlayerRank>
<UniqueId>|<Rank2PlayerName>|<Rank2PlayerScore>|<Rank2PlayerRank>
<UniqueId>|<Rank3PlayerName>|<Rank3PlayerScore>|<Rank3PlayerRank>
<UniqueId>|<Rank4PlayerName>|<Rank4PlayerScore>|<Rank4PlayerRank>
<UniqueId>|<Rank5PlayerName>|<Rank5PlayerScore>|<Rank5PlayerRank>`

example:

REQUEST `/121` will find the rank of player with id 121

RESPONSE
`121|Saket|944|1
121|Saket|944|1
691|Priyal|373|2
721|Jhanvi|370|3
711|Akshay|220|4
701|Ajinkya|124|5`

This is pipe separated data with first line as the data of the input user followed by top 5 players
