'''Website module.'''
import csv
import os
import json
from random import randint
from flask import (Flask, Response, flash, redirect, render_template, request,
                   url_for)
from werkzeug.utils import secure_filename

# relies on groupre having been installed to the machine running this script
application = Flask(__name__)

# application.config['UPLOAD_FOLDER'] = UPLOAD_FOLDER
application.config['MAX_CONTENT_LENGTH'] = 5 * 1024 * 1024
application.config['SECRET_KEY'] = '5791628bb0b45ce0c676dfde280ba245'

#helper scripts
@application.route("/")
def hello():
    return render_template('index.html')

if __name__ == "__main__":
    application.secret_key = '5791628bb0b45ce0c676dfde280ba245'
    application.run(debug=True)
