'use strict'

const config = require('./config')
const mysql = require('mysql')
const bluebird = require('bluebird')
const pool = mysql.createPool({
  connectionLimit: config.sql.connectionLimit,
  host: 'addhostname',
  user: 'addusername',
  password: 'addpassword',
  database: 'adddatabase',
  port: 3306,
  debug: false,
  multipleStatements: true
})

pool.getConnection((err, connection) => {
  if (err) {
    if (err.code === 'PROTOCOL_CONNECTION_LOST') {
      console.error('Database connection was closed.')
    }
    if (err.code === 'ER_CON_COUNT_ERROR') {
      console.error('Database has too many connections.')
    }
    if (err.code === 'ECONNREFUSED') {
      console.error('Database connection was refused.')
    }
  }
  if (connection) connection.release()
})

pool.query = bluebird.promisify(pool.query)

module.exports = pool
