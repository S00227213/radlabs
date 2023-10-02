const express = require('express');
const mongoose = require('mongoose');
const app = express();
const port = process.env.PORT || 3001;
require('dotenv').config();


app.use(express.json());

// Require the contacts router
const contacts = require('./routes/contacts');

// Use the contacts router with the specified route 
app.use('/api/v1/contacts', contacts);

// Retrieve connection string from environment variables
const connectionString = process.env.CONNECTIONSTRING;

// Connect to MongoDB with error handling
mongoose
  .connect(connectionString, {
    useNewUrlParser: true,
    useUnifiedTopology: true,
  })
  .then(() => {
    console.log('DB connected ' + connectionString);

    // Start the Express server
    app.listen(port, () => console.log(`Example app listening on port ${port}!`));
  })
  .catch((error) => {
    console.error(`Database connection refused ${error}`);
    process.exit(2);
  });

  module.exports = app; 
