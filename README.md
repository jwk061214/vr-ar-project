# 🚀 VR/AR Unity 프로젝트 – 협업 가이드 (Collaboration Guide)

본 문서는 팀 프로젝트의 원활한 협업을 위해 **Git/GitHub 사용 규칙, 브랜치 전략, Unity 프로젝트 구조, 커밋 규칙** 등을 정리한 가이드입니다.

---

## 1. Git 브랜치 전략


| 브랜치 | 목적 및 특징 | 규칙 |
| :--- | :--- | :--- |
| **main** | **출시 가능한 안정 버전** (Production Ready) | 🚫 **직접 push 금지.** 반드시 **PR(Pull Request)로만 merge** 가능. Branch Protection Rule 적용됨. |
| **dev** | **개발 통합 브랜치** (Integration) | 모든 기능 개발 내용이 먼저 합쳐지는 곳. **팀원은 항상 dev에서 시작.** main으로 PR을 보내기 전 마지막 검증 단계. |

### 🔹 Feature 브랜치 생성 예시

* `feature/player-movement`
* `feature/enemy-ai`
* `feature/ui-mainmenu`

---

## 2. Git 사용 규칙 (워크플로우)

### 1) 최초 프로젝트 클론 및 `dev` 브랜치 체크아웃
```bash
git clone [https://github.com/사용자명/레포명.git](https://github.com/사용자명/레포명.git)
cd 레포명
git checkout dev
```
요청하신 대로, 이전에 제공해 드렸던 협업 가이드의 원본 마크다운 텍스트 자체를 다시 제공합니다.

Markdown

# 🚀 VR/AR Unity 프로젝트 – 협업 가이드 (Collaboration Guide)

본 문서는 팀 프로젝트의 원활한 협업을 위해 **Git/GitHub 사용 규칙, 브랜치 전략, Unity 프로젝트 구조, 커밋 규칙** 등을 정리한 가이드입니다.

---

## 1. Git 브랜치 전략


[Image of Git Flow Branching Strategy]


본 프로젝트는 **main / dev / feature**의 3단계 브랜치 전략을 사용합니다.

| 브랜치 | 목적 및 특징 | 규칙 |
| :--- | :--- | :--- |
| **main** | **출시 가능한 안정 버전** (Production Ready) | 🚫 **직접 push 금지.** 반드시 **PR(Pull Request)로만 merge** 가능. Branch Protection Rule 적용됨. |
| **dev** | **개발 통합 브랜치** (Integration) | 모든 기능 개발 내용이 먼저 합쳐지는 곳. **팀원은 항상 dev에서 시작.** main으로 PR을 보내기 전 마지막 검증 단계. |
| **feature/** | **작업 단위별 개별 브랜치** (Working Branch) | 작업 단위별로 생성하여 개별 작업을 수행. 완료 후 dev로 PR 요청. |

### 🔹 Feature 브랜치 생성 예시

* `feature/player-movement`
* `feature/enemy-ai`
* `feature/ui-mainmenu`

---

## 2. Git 사용 규칙 (워크플로우)

### 1) 최초 프로젝트 클론 및 `dev` 브랜치 체크아웃
```bash
git clone [https://github.com/사용자명/레포명.git](https://github.com/사용자명/레포명.git)
cd 레포명
git checkout dev
```
### 2) 새로운 기능 작업 시 feature 브랜치 생성
❗ dev 브랜치에서 항상 최신 코드 pull 후 작업 시작합니다.
```bash
git checkout dev
git pull # dev의 최신 상태 반영
git checkout -b feature/작업명 # 새 feature 브랜치 생성 및 이동
```
### 3) 작업 후 커밋 및 푸시
```bash
git add .
git commit -m "태양: 작업내용 요약" 
git push -u origin feature/작업명
```

### 4) GitHub에서 PR 생성 및 Merge
base: dev
코드 리뷰 후 dev에 merge.

### 5) dev → main PR (최종 배포용)
main 직접 수정 금지.
dev에서 최종 테스트 완료 후, main 브랜치로 PR 요청 및 Merge.

## 4. Unity 프로젝트 Git 구조
Unity의 자동 생성 파일을 제외하고, 아래 필수 폴더만 Git에 포함합니다.

🟢 Git에 포함해야 하는 폴더 (필수)
  - Assets/ (단, AssetStore 제외)
  - Packages/
  - ProjectSettings/

🔴 반드시 제외 (.gitignore)
다음 파일/폴더들은 .gitignore 파일에 반영되어 있으며, Git에 포함되지 않습니다.
  - Library/
  - Temp/
  - Obj/
  - Logs/
  - UserSettings/
  - Build/ 및 빌드 관련 폴더
  - Assets/AssetStore/
  - 고해상도 에셋 (예: Assets/Textures/HighRes/) 등 용량이 큰 에셋

add 예시
```bash
git add Assets/Scripts
git add Assets/Scenes
git add Assets/Prefabs
git add Assets/Materials
git add Assets/Animations
git add Assets/Models
git add Assets/Sprites

git add Packages/manifest.json
git add Packages/packages-lock.json

git add ProjectSettings

git add .gitignore
```
