const express = require('express')
const bodyParser = require('body-parser')
const cors = require('cors')
const helmet = require('helmet')
const scoreController =  require('./score.controller')
const app = express()

// app.use(bodyParser.json())
// app.use(bodyParser.urlencoded({
//         extended: false
// }))
app.use(cors())
app.use(helmet())

app.get('/add/:name/:score', scoreController.addScore)
app.get('/:id', scoreController.fetchScore)

app.set('port', (process.env.PORT || 5000))

app.listen(app.get('port'), function() {
  console.log("Node app is running at localhost:" + app.get('port'))
})
