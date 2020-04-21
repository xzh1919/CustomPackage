#!/bin/bash

git add .
git commit -m fix
git push origin master

git subtree split --prefix=Assets/Framework --branch upm
git tag 1.0.2 upm
git push origin upm --tags