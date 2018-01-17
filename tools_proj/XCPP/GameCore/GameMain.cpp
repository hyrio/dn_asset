#include "GameMain.h"
#include "XEntityMgr.h"
#include "XScene.h"

void GameMain::OnStart()
{
	//XEntityMgr::Instance()->CreatePlayer();
	XScene::Instance()->Enter(401);
}

void GameMain::Ontick(float delta)
{
	XTimerMgr::Instance()->Update(delta);
	XEntityMgr::Instance()->Update(delta);
}


void GameMain::Start()
{
	m_start = true;
	m_diff = 0;
	OnStart();
}


void GameMain::Stop()
{
	m_start = false;
}

void GameMain::Quit()
{
	m_start = false;
	GameObjectMgr::Instance()->Clear();
	XEntityMgr::Instance()->UnloadAll();
	XTimerMgr::Instance()->RemoveAllTimer();
}