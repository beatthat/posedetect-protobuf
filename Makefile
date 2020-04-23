PROJECT=$(shell git rev-parse --show-toplevel 2> /dev/null)
DIR=$(shell pwd)
DOCKER_PROTOC=namely/protoc-all:1.29_0
UID=$(shell id -u)
GID=$(shell id -g)

.PHONY: types-python
types-csharp:
	cd proto && \
	docker run \
			--rm \
			-u $(UID):$(GID) \
			-v $(DIR)/proto:/defs \
			-v $(DIR)/posedetect_protobuf:/posedetect_protobuf \
		$(DOCKER_PROTOC) -l csharp -f poses.proto -o /posedetect_protobuf

.PHONY: types-python
types-python:
	cd proto && \
	docker run \
			--rm \
			-u $(UID):$(GID) \
			-v $(DIR)/proto:/defs \
			-v $(DIR)/posedetect_protobuf:/posedetect_protobuf \
		$(DOCKER_PROTOC) -l python -f poses.proto -o /posedetect_protobuf

.PHONY: proto-shell
proto-shell:
	docker run \
			--rm \
			-it \
			-u $(UID):$(GID) \
			-v $(DIR)/proto:/defs \
			-v $(DIR)/posedetect_protobuf:/posedetect_protobuf \
			--entrypoint /bin/bash \
		$(DOCKER_PROTOC)

# virtualenv used for pytest
VENV=.venv
$(VENV):
	$(MAKE) test-env-create

.PHONY: test-env-create
test-env-create: virtualenv-installed
	[ -d $(VENV) ] || virtualenv -p python3.8 $(VENV)
	$(VENV)/bin/pip install --upgrade pip
	$(VENV)/bin/pip install -r ./requirements.test.txt

virtualenv-installed:
	$(PROJECT)/bin/virtualenv_ensure_installed.sh

PHONY: test
test: $(VENV)
	PYTHONPATH=$(shell echo $${PYTHONPATH}):$(DIR) $(VENV)/bin/py.test -vv $(args)


.PHONY: format
format: $(VENV)
	$(VENV)/bin/black posedetect_protobuf

.PHONY: test-format
test-format: $(VENV)
	$(VENV)/bin/black --check posedetect_protobuf

.PHONY: test-lint
test-lint: $(VENV)
	$(VENV)/bin/flake8 .

.PHONY: test-all
test-all: test-format test-lint test
