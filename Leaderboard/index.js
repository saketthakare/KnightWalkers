const express = require('express')
const bodyParser = require('body-parser')
const cors = require('cors')
const helmet = require('helmet')
const httpStatus = require('http-status')
const sql = require('./database-connection')
const app = express()
const config = require('./config')

app.use(bodyParser.json())
app.use(bodyParser.urlencoded({
        extended: false
}))
app.use(cors())
app.use(helmet())


app.listen(config.port, (err) => {
    if (err) {
      console.log(`Error : ${err}`)
      process.exit(-1)
    }
    console.log(`${config.app} is running on ${config.port}`)
})