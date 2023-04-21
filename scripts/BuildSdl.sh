#!/bin/bash

if [ $# -ne 3 ]; then
  echo "Requires 3 parameters! <SDL_LOCATION> <BUILD_DIRECTORY> <NATIVE_OUTPUT_DIRECTORY>"
  exit 1
fi

SDL_LOC=$1
BUILD_DIR=$2
OUT_LOC=$3

current_loc=$(pwd)

mkdir -p "${current_loc}/${BUILD_DIR}"

pushd "${current_loc}/${BUILD_DIR}" || exit 1

cmake "${current_loc}/${SDL_LOC}" -DCMAKE_BUILD_TYPE=Release

cmake --build . --config Release || exit 1

popd || exit 1

mkdir -p "${current_loc}/${OUT_LOC}"

cp -L "${current_loc}/${BUILD_DIR}/libSDL2-2.0.so" "${current_loc}/${OUT_LOC}"