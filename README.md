
# Creating TTL Index
db.Carts.createIndex({ "ExpireAt": 1 },{ expireAfterSeconds: 0 , background: true}); 

# Use Case
300 documents created at 1 second ExpireAt intervals.

# Result
MongoDb expires 60 documents simultaneously in every minute.
This is not a certain value cause of MongoDb doesn't guarenteed expiration time.
But, it is showing us MongoDb checks expiration time for every minute.


