from fastapi import FastAPI
from models.user import User
app = FastAPI()

@app.post("/api/register")
def register(user: User):
    pass