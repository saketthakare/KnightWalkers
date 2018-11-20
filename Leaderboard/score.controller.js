'use strict'

const httpStatus = require('http-status')
const sql = require('./database-connection')


exports.addScore = async (req, res, next) => {
    try {
        if(!req.body.name || !req.body.score) { throw 'Invalid Data' }
        const response = {payLoad: {}}
        const newScore = {
          'name': req.body.name,
          'score': req.body.score
        }
        const currentScore = await sql.query('INSERT INTO score SET ?', newScore)
        const allScore = await sql.query(`SELECT * FROM score ORDER BY score DESC`)
        const currentRun = {
            id : currentScore.insertId,
            name : '',
            score : '',
            rank : 0
        }
        const leaderboardList = []
        for (let index = 0; index < allScore.length; index++) {
            const element = allScore[index]
            if(index < 5){
                const player = element
                player.rank = index + 1
                leaderboardList.push(player)
            }
            if(element.id == currentScore.insertId){
                currentRun.name = element.name
                currentRun.score = element.score
                currentRun.rank = index + 1
            }            
        }
        response.payLoad = {
            current : currentRun,
            leaderboard : leaderboardList
        }
        res.status(httpStatus.OK)
        res.send(response)
      } catch (error) {
        res.status(httpStatus.INTERNAL_SERVER_ERROR)
        res.send(response)
      }
}
