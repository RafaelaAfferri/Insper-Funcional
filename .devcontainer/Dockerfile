##############################################################################

# Base image with VS Code setup
FROM mcr.microsoft.com/vscode/devcontainers/base:ubuntu-24.04 AS base

RUN apt update -y && \
    apt upgrade -y && \
    apt autoremove -y && \
    apt autoclean -y

RUN apt install -y \
    curl \
    build-essential \
    libffi8 \
    libffi-dev \
    libgmp10 \
    libgmp-dev \
    libncurses-dev   


##############################################################################

FROM base AS user-setup

# Switch to non-root user 'vscode' from now on
USER vscode

# Set the default shell to bash instead of sh
ENV SHELL=/bin/bash

RUN mkdir -p /home/vscode/.local/bin
ENV PATH=${PATH}:/home/vscode/.local/bin

##############################################################################

# Setup Haskell environment
FROM user-setup AS haskell-setup

# Install ghcup
RUN curl --proto '=https' --tlsv1.2 -sSf https://get-ghcup.haskell.org | sh
ENV PATH=${PATH}:/home/vscode/.ghcup/bin

# Upgrade ghcup to the latest version.
RUN ghcup upgrade

# Install GHC
RUN ghcup install ghc recommended
RUN ghcup set ghc recommended

# Install HLS
RUN ghcup install hls recommended
RUN ghcup set hls recommended

# Install cabal
RUN ghcup install cabal recommended
RUN ghcup set cabal recommended
RUN cabal update

# Install stack
RUN ghcup install stack recommended
RUN ghcup set stack recommended
RUN stack update

##############################################################################

# Install Haskell utilities
FROM haskell-setup AS haskell-utils

# Install HLint and Stylish Haskell
RUN cabal install hlint stylish-haskell

##############################################################################
