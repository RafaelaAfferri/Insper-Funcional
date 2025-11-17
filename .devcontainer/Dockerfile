# Base image with VS Code setup
FROM mcr.microsoft.com/vscode/devcontainers/base:ubuntu-22.04 AS base


FROM base AS updater

RUN apt-get update && apt-get upgrade -y


FROM updater AS apt_dependencies

RUN apt-get install -y build-essential\
    curl \
    libffi-dev \
    libffi8 \
    libgmp-dev \
    libgmp10 \
    libncurses-dev \
    libncurses6 \
    libtinfo6 \
    pkg-config


FROM apt_dependencies AS ghcup_installation

USER vscode

RUN curl --proto '=https' --tlsv1.2 -sSf https://get-ghcup.haskell.org | sh


FROM ghcup_installation AS ghc_toolchain

# Add ghcup to PATH
ENV PATH=${PATH}:/home/vscode/.local/bin
ENV PATH=${PATH}:/home/vscode/.ghcup/bin

RUN bash -c "ghcup upgrade"

# Install cabal
RUN bash -c "ghcup install cabal"

# Install stack
RUN bash -c "ghcup install stack"

# Install HLS
RUN bash -c "ghcup install hls"

# Install GHC
RUN bash -c "ghcup install ghc"

FROM ghc_toolchain AS final

RUN cabal update
RUN cabal install hlint stylish-haskell

RUN stack update

# Set the default shell to bash instead of sh
ENV SHELL /bin/bash
