'use strict'

const httpStatus = require('http-status')
const sql = require('./database-connection')

exports.addScore = async (req, res, next) => {
    try {
        if(!req.params.name || !req.params.score) { throw 'Invalid Data' }
        const newScore = {
          'name': req.params.name,
          'score': parseInt(req.params.score)
        }
        const currentScore = await sql.query('INSERT INTO score SET ?', newScore)
        res.setHeader('content-type', 'text/plain');
        res.status(httpStatus.OK)
        res.send(''+currentScore.insertId)
      } catch (error) {
        res.status(httpStatus.INTERNAL_SERVER_ERROR)
        res.send('error')
      }
}

exports.fetchScore = async (req, res, next) => {
    try {
        if(!req.params.id) { throw 'Invalid Data' }
        const id = parseInt(req.params.id)
        const allScore = await sql.query(`SELECT * FROM score ORDER BY score DESC`)
        let leaderboardList = ''
        for (let index = 0; index < allScore.length; index++) {
            const element = allScore[index]
            if(index < 5){
                const player = element
                player.rank = index + 1
                leaderboardList += player.id+'|'+player.name+'|'+player.score+'|'+player.rank+'\n'
            }
            if(element.id == id){
                const player = element
                player.rank = index + 1
                leaderboardList = id+'|'+player.name+'|'+player.score+'|'+player.rank+'\n' + leaderboardList
            }            
        }
        res.setHeader('content-type', 'text/plain');
        res.status(httpStatus.OK)
        res.send(leaderboardList)
      } catch (error) {
          console.error(error)
        res.status(httpStatus.INTERNAL_SERVER_ERROR)
        res.send('error')
      }
}
