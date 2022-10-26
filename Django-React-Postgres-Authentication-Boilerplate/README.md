# Simple Django React Postgres Authentication Boilerplate

## For Running the Project

### Requirements

`Node, Python, NPM package manager, Postgres`

### Clone the repository:

- clone the project using git command line. 

```
git clone https://github.com/Dinuda/Django-React-Postgres-Authentication-Boilerplate.git .
```

## Backend

### 1. Go to the root folder and perform the following commands:

`cd backend`

### 2. Create and activate the virtual environment


```
Windows
---------
python -m venv venv
venv\Scripts\activate

MACOS (M1)
----------
virtualenv venv
source venv/bin/activate
```

### 3. Install required packages

` use pip3 if you are using python3.6 or higher. `
```
pip install -r requirements.txt
```

### 4. Apply Migrations
```
python3 manage.py makemigrations
python3 manage.py migrate
```

### 5. Run the server

```
python3 manage.py runserver
```

<br>

## Frontend
(open a new command process)

- Navigate to the root folder
- Key in `cd frontend`

### 1. Installing packages

```
npm install
```


### 2. Run the application

```
npm run start
```

> make sure that both frontend and backend are running

## Check your running application

- head over to `http://localhost:3000/` 



## For Running the Project

- `.gitignore` is placed seperately in backend and frontend folders



## Credits
https://github.com/sushil-kamble/django-react-auth
